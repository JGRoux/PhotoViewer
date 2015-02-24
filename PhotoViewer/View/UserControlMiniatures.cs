using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyPhotoViewer.Model;
using MyPhotoViewer.Controller;

namespace MyPhotoViewer.View
{
    /* User control class displaying miniatures of an album.
    * 
    * Implementations:
    * Add multiple pictures to the album with button add and file chooser or by drag&drop
    * Start diaporama (diaporama start with first selected picture or if there is not by first picture)
    * Delete selected pictures with button delete
    * Display picture and infos (user control picture) by double clicking on one picture
    * 
    */

    public partial class UserControlMiniatures : UserControl
    {
        private Album album;
        private PhotoViewer photoViewer;
        private ImageList imageList = new ImageList();

        public event EventHandler displayPicture;
        public event EventHandler Diaporama;

        public UserControlMiniatures(PhotoViewer photoViewer, Album album)
        {
            InitializeComponent();
            this.photoViewer = photoViewer;
            this.album = album;
        }

        // Call on load
        private void UserControlMiniatures_Load(object sender, EventArgs e)
        {
            // Set tooltip on mouse over
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnAddPictures, "Add pictures to this album");
            toolTip.SetToolTip(this.btnDiaporama, "Diaporama");
            toolTip.SetToolTip(this.btnDeletePictures, "Delete pictures");

            this.Dock = DockStyle.Fill;

            // If there is no picture in the album display label message
            if (this.album.PicturesList.Count == 0)
                this.showNoPicture();

            this.lblAlbumName.Text = this.album.Name;

            this.setButtonState();
            this.createListView();
        }

        // Fill the listview with picture items.
        private void createListView()
        {
            this.imageList.ColorDepth = ColorDepth.Depth32Bit; // Set higher picture quality
            this.imageList.ImageSize = new Size(100, 100); // Set miniatures size

            // Set pictures to listview
            if (this.album.PicturesList != null)
            {
                for (int i = 0; i < this.album.PicturesList.Count; i++)
                {
                    // Use filestream to unlock the file. Imperative to allow deleting file or album.
                    using (FileStream fs = new FileStream("albums\\" + this.album.Name + "\\" + this.album.PicturesList[i].Name, FileMode.Open, FileAccess.Read))
                    {
                        this.imageList.Images.Add(Image.FromStream(fs));
                    }
                    this.listViewMiniatures.Items.Add(this.album.PicturesList[i].Name, i);
                }
                // Attach imagelist to listview
                this.listViewMiniatures.LargeImageList = this.imageList;
            }
        }

        // Display label no picture.
        private void showNoPicture()
        {
            this.lblNoPicture.BringToFront();
            this.lblNoPicture.Show();
        }

        // Set buttons state off/on if there is no picture or not.
        private void setButtonState()
        {
            Boolean state = false;
            if (album.PicturesList.Count > 0)
                state = true;

            this.btnDiaporama.Enabled = state;
            this.btnDeletePictures.Enabled = state;
        }

        // Double click event on listview. Display picture of miniature clicked to user control picture.
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            displayPicture(this, e);
        }

        // Get new pictures from files path. Copy files to album folder. Add picture to xml. Add miniatures to listview.
        private void getFiles(string[] files)
        {
            // Read the files
            foreach (String file in files)
            {
                // New picture
                try
                {
                    String path = "albums\\" + this.album.Name + file.Substring(file.LastIndexOf('\\'));
                    if (File.Exists(path))
                        MessageBox.Show("File " + file.Substring(file.LastIndexOf('\\') + 1) + " already exist in this album.");
                    else
                    {
                        File.Copy(file, path, true);
                        this.album.addPicture(file.Substring(file.LastIndexOf('\\') + 1));
                        // Use filestream to unlock the file. Imperative to allow deleting file or album.
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            this.imageList.Images.Add(Image.FromStream(fs));
                        }
                        this.listViewMiniatures.Items.Add(file.Substring(file.LastIndexOf('\\') + 1), album.PicturesList.Count - 1);
                        this.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\') + 1));
                    Console.WriteLine(ex.StackTrace);
                }
            }
            // Hide label no picture.
            if (this.album.PicturesList.Count != 0)
                this.lblNoPicture.Hide();

            this.setButtonState();
            this.photoViewer.save();
        }

        // Button add picture click event. Open file chooser and get new pictures.
        private void btnAddPictures_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.png, *.jpg)|*.png;*.jpg";
            openFileDialog.Title = "Select some pictures";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.getFiles(openFileDialog.FileNames);
            }
        }

        // Drag enter event on listview or lblNoPicture. Make cursor copy on drag.
        private void picture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // Drag&Drop event on listview or lblNoPicture. Get new pictures.
        private void picture_DragDrop(object sender, DragEventArgs e)
        {
            this.getFiles((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        // Button diaporama click event. Start diaporama.
        private void btnDiaporama_Click(object sender, EventArgs e)
        {
            Diaporama(this, e);
        }

        // Listview mouse move event. Make cursor hand over item.
        private void listView_MouseMove(object sender, MouseEventArgs e)
        {
            if (listViewMiniatures.HitTest(e.X, e.Y).Item != null)
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        // Button delete click event. Delete every picture selected. Ask user confirmation.
        private void btnDeletePictures_Click(object sender, EventArgs e)
        {
            if (this.listViewMiniatures.SelectedItems.Count != 0)
                if (MessageBox.Show("The pictures selected will be deleted.", "Delete pictures", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (ListViewItem item in this.listViewMiniatures.SelectedItems)
                    {
                        this.album.removePicture(item.SubItems[0].Text);
                        this.imageList.Images[item.Index].Dispose();
                        this.listViewMiniatures.Items.Remove(item);
                        File.Delete("albums\\" + this.album.Name + "\\" + item.SubItems[0].Text);
                    }
                    if (this.album.PicturesList.Count == 0)
                        this.showNoPicture();

                    this.setButtonState();
                    this.photoViewer.save();
                }
        }
    }
}
