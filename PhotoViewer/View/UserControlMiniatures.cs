using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotoViewer.Model;

namespace MyPhotoViewer.View
{
    public partial class UserControlMiniatures : UserControl
    {
        ImageList imageList1 = new ImageList();
        public Album album { get; set; }
        PhotoViewer photoViewer;
        int numberOfPictures = 0;

        public event EventHandler displayPicture;

        public UserControlMiniatures(PhotoViewer photoViewer, Album album)
        {
            InitializeComponent();

            this.photoViewer = photoViewer;
            this.album = album;

            this.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.Dock = DockStyle.Fill;

            if(this.album.PicturesList != null)
            {
                numberOfPictures = 0;
                foreach (Picture picture in album.PicturesList)
                {
                    numberOfPictures++;
                    this.imageList1.Images.Add(new Bitmap("albums\\" + this.album.Name + "\\" + picture.Name, true));
                    this.listView1.Items.Add(new ListViewItem(picture.Name)).ImageIndex = numberOfPictures-1;
                }
            }
            this.createListVew();
        }

        private void createListVew()
        {
            // Add event handlers for the drag & drop functionality
            if(this.album.PicturesList.Count > 0)
                this.label1.Hide();
            this.listView1.AllowDrop = true;
            this.listView1.DragDrop += new DragEventHandler(this.listview1_DragDrop);
            this.listView1.DragEnter += new DragEventHandler(listView1_DragEnter);
            this.listView1.Dock = DockStyle.Fill;
            this.listView1.ima
            this.listView1.LargeImageList = imageList1;
            this.imageList1.ImageSize = new Size(100, 100);
            this.panel1.Controls.Add(listView1);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            displayPicture(this, e);
        }

        private void getFiles(string[] files){
        // Read the files
                foreach (String file in files)
                {
                    // New picture
                    try
                    {
                        numberOfPictures++;
                        System.IO.File.Copy(file, "albums\\"+this.album.Name+file.Substring(file.LastIndexOf('\\')), true);
                        this.album.addPicture(file.Substring(file.LastIndexOf('\\')+1));
                        this.imageList1.Images.Add(new Bitmap("albums\\" + this.album.Name + "\\" + file.Substring(file.LastIndexOf('\\') + 1), true));
                        this.listView1.Items.Add(new ListViewItem(file.Substring(file.LastIndexOf('\\')+1))).ImageIndex = numberOfPictures - 1;
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\')+1)
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
                this.photoViewer.save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Images (*.png, *.jpg)|*.png;*.jpg";
            openFileDialog1.Title = "Select some pictures";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.getFiles(openFileDialog1.FileNames);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listview1_DragDrop(object sender, DragEventArgs e)
        {
           this.getFiles((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            this.label1.Hide();
            this.createListVew();
            this.getFiles((string[])e.Data.GetData(DataFormats.FileDrop));
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {

        }


        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        
    }
}
