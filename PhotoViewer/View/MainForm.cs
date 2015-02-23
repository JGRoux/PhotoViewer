using MyPhotoViewer.Controller;
using MyPhotoViewer.Model;
using MyPhotoViewer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoViewer
{
    public partial class MainForm : Form
    {
        private ContextMenuStrip listboxContextMenu;
        private PhotoViewer photoViewer;
        private Diaporama diaporama;

        public MainForm()
        {
            InitializeComponent();
        }

        // Call on load
        private void Form1_Load(object sender, EventArgs e)
        {
            this.diaporama = new Diaporama(this);
            this.listboxContextMenu = new ContextMenuStrip();
            this.listboxContextMenu.Opening += new CancelEventHandler(listboxContextMenu_Opening);
            this.listboxContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(listboxContextMenu_ItemClicked);
            this.lstBxAlbums.ContextMenuStrip = listboxContextMenu;

            // Set tooltip on mouse over
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnAddAlbum, "Create a new album");

            this.photoViewer = new PhotoViewer();
            // Add albums to listbox
            foreach (Album album in this.photoViewer.AlbumsList)
                this.lstBxAlbums.Items.Add(album.Name);
        }

        // Context menu strip content
        private void listboxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            //clear the menu and add custom items
            this.listboxContextMenu.Items.Clear();
            if (this.lstBxAlbums.SelectedIndex != -1)
            {
                this.listboxContextMenu.Items.Add("Rename");
                this.listboxContextMenu.Items.Add("Delete");
            }
        }

        // Context menu strip click events (Rename/Delete album)
        private void listboxContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.listboxContextMenu.Hide();
            if (e.ClickedItem.ToString().Equals("Rename")) // Display dialog albm name to rename
            {
                DialogAlbumName dialog = new DialogAlbumName();
                dialog.getTextBox().Text = this.lstBxAlbums.SelectedItem.ToString();
                if (albumNameCheck(dialog))
                {
                    // Move directory name / change xml content / refresh listbox
                    Directory.Move("albums\\" + this.lstBxAlbums.SelectedItem.ToString(), "albums\\" + dialog.getTextBox().Text);
                    this.photoViewer.getAlbum(this.lstBxAlbums.SelectedItem.ToString()).Name = dialog.getTextBox().Text;
                    this.photoViewer.save();
                    int index = this.lstBxAlbums.SelectedIndex;
                    lstBxAlbums.Items.RemoveAt(index);
                    lstBxAlbums.Items.Insert(index, dialog.getTextBox().Text);
                    this.lstBxAlbums.SelectedIndex = index;
                }
                dialog.Dispose();
            }
            else if (e.ClickedItem.ToString().Equals("Delete"))
                this.rmAlbum();
        }

        // Remove an album. Display dialog to confirm. (delete directory and files within it / xml content)
        private void rmAlbum()
        {
            if (this.lstBxAlbums.SelectedIndex != -1)
                if (MessageBox.Show("Every pictures of the album " + this.lstBxAlbums.SelectedItem.ToString() + " will be deleted on the hard drive.", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.splitContainer.Panel2.Controls.Clear();
                    Directory.Delete("albums\\" + this.lstBxAlbums.SelectedItem.ToString(), true);
                    this.photoViewer.delAlbum(this.lstBxAlbums.SelectedItem.ToString());
                    this.photoViewer.save();
                    this.lstBxAlbums.Items.Remove(this.lstBxAlbums.SelectedItem);
                    this.splitContainer.Panel2.Controls.Add(this.lblWelcome);
                }
        }

        // Click event on button to add album. Display dialog to ask for album name
        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            DialogAlbumName dialog = new DialogAlbumName();
            if (albumNameCheck(dialog))
            {
                this.lstBxAlbums.Items.Add(dialog.getTextBox().Text);
                Directory.CreateDirectory("albums\\" + dialog.getTextBox().Text); // Create folder for the album
                this.photoViewer.addAlbum(dialog.getTextBox().Text, DateTime.Now);
                this.photoViewer.save();
            }
            dialog.Dispose();
            this.lstBxAlbums.Focus(); // Return focus to list box album
        }

        // Check if album name entered is correct
        private Boolean albumNameCheck(DialogAlbumName dialog)
        {
            // Display dialog while a correct name is entered or user quit
            do
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    // Album name cannot be emtpy and 2 albums can't have the same name
                    if (dialog.getTextBox().Text.Equals(""))
                        MessageBox.Show("Please enter a name !");
                    else if (this.photoViewer.getAlbum(dialog.getTextBox().Text) != null)
                        MessageBox.Show("An another album have already this name !");
                    else
                        return true;
                }
                else
                    return false;
            } while (this.photoViewer.getAlbum(dialog.getTextBox().Text) != null || dialog.getTextBox().Text.Equals(""));
            return false;
        }

        // Mouse click on listbox
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //select the item under the mouse pointer
            this.lstBxAlbums.SelectedIndex = lstBxAlbums.IndexFromPoint(e.Location);

            if ((e.Button == MouseButtons.Right) && (this.lstBxAlbums.SelectedIndex != -1)) // Display context menu strip album (Rename/Delete)
                this.listboxContextMenu.Show();

            if (e.Button == MouseButtons.Left) // Display album miniatures
                this.displayAlbumsMiniatures();
        }

        private void lstBxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.displayAlbumsMiniatures();
        }

        // Display user control miniatures
        private void displayAlbumsMiniatures()
        {
            if (this.lstBxAlbums.SelectedIndex != -1)
            {
                this.splitContainer.Panel2.Controls.Clear();
                UserControlMiniatures Ucm1 = new UserControlMiniatures(this.photoViewer, this.photoViewer.getAlbum(lstBxAlbums.SelectedItem.ToString()));
                this.splitContainer.Panel2.Controls.Add(Ucm1);
                Ucm1.displayPicture += Ucm1_displayPicture;
                Ucm1.Diaporama += Ucm1_Diaporama;
            }
        }

        // Display user control photo in diaporama mode
        private void Ucm1_Diaporama(object sender, EventArgs e)
        {
            if (!this.diaporama.IsFullScreen)
            {
                // Hide the listbox album and cursor. Maximize user control picture panel. Set fullscreen mode.          
                this.splitContainer.Panel1.Hide();
                this.splitContainer.Panel2.Dock = DockStyle.Fill;
                Cursor.Hide();
                if (sender is MyPhotoViewer.View.UserControlMiniatures)
                    Ucm1_displayPicture(sender, e);
                ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).setFullScreen(true);
                ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Start();
                this.diaporama.setFullScreen(true);
            }
            this.Focus(); // Return the focus from the button clicked to the form. Else there is no key event.
        }

        // Display user control photo
        private void Ucm1_displayPicture(object sender, EventArgs e)
        {
            int index = 0;
            var Ucm = sender as UserControlMiniatures;
            this.splitContainer.Panel2.Controls.Clear();
            if (Ucm.listViewMiniatures.SelectedIndices.Count != 0)
                index = Ucm.listViewMiniatures.SelectedIndices[0];
            UserControlPictures Ucp = new UserControlPictures(this.photoViewer, this.photoViewer.getAlbum(lstBxAlbums.SelectedItem.ToString()), index);
            Ucp.Dock = DockStyle.Fill;
            this.splitContainer.Panel2.Controls.Add(Ucp);
            Ucp.goBack += Ucp_back;
            Ucp.startDiaporama += Ucm1_Diaporama;
        }

        // Return to album miniatures from user control photo
        private void Ucp_back(object sender, EventArgs e)
        {
            this.displayAlbumsMiniatures();
        }

        // Restart the timer after user manually choose previous/next picture
        private void resetTimer()
        {
            ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Stop();
            ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Start();
        }

        // Get key events everywhere
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.splitContainer.Panel2.Controls[0] is UserControlPictures)
                if (keyData == Keys.Left) // Display next picture
                {
                    ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).previousPicture();
                    if (this.diaporama.IsFullScreen)
                        this.resetTimer();
                    return true;
                }
                else if (keyData == Keys.Right) // Display previous picture
                {
                    ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).nextPicture();
                    if (this.diaporama.IsFullScreen)
                        this.resetTimer();
                    return true;
                }

            if (this.diaporama.IsFullScreen)
            {
                if (keyData == Keys.Add)
                    ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Interval += 500;
                else if (keyData == Keys.Subtract)
                {
                    if (((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Interval > 500)
                        ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Interval -= 500;
                }
                else if (keyData == Keys.Escape)
                {
                    // Unhide panel of album choice.
                    this.splitContainer.Panel1.Show();
                    this.splitContainer.Panel2.Dock = DockStyle.None;
                    Cursor.Show();
                    ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).setFullScreen(false);
                    ((UserControlPictures)this.splitContainer.Panel2.Controls[0]).timer.Stop();
                    this.diaporama.setFullScreen(false);
                }
                return true; // If fullscreen mode enabled does not call other key event
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
