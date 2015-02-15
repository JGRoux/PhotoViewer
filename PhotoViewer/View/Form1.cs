using MyPhotoViewer.Model;
using MyPhotoViewer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoViewer
{
    public partial class MainWindow : Form
    {
        private ContextMenuStrip listboxContextMenu;
        private PhotoViewer photoViewer;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxContextMenu = new ContextMenuStrip();
            listboxContextMenu.Opening += new CancelEventHandler(listboxContextMenu_Opening);
            listBox1.ContextMenuStrip = listboxContextMenu;
            this.photoViewer = new PhotoViewer();
            foreach (Album album in this.photoViewer.AlbumsList)
            {
                this.listBox1.Items.Add(album.Title);
            }
        }

        private void listboxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            //clear the menu and add custom items
            // listBox1.SelectedItem.ToString()
            listboxContextMenu.Items.Clear();
            listboxContextMenu.Items.Add("Rename");
            listboxContextMenu.Items.Add("Delete");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            DialogAlbumName dialog = new DialogAlbumName();
            do
            {
                // Show testDialog as a modal dialog and determine if DialogResult = OK. 
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    // 2 albums can't have the same name
                    if (dialog.getTextBox().Text.Equals(""))
                        MessageBox.Show("Please enter a name !");
                    else if( this.photoViewer.getAlbum(dialog.getTextBox().Text) == null)
                    {
                        this.listBox1.Items.Add(dialog.getTextBox().Text);
                        this.photoViewer.addAlbum(dialog.getTextBox().Text, dialog.getTextBox().Text, DateTime.Now);
                        this.photoViewer.save();
                        break;
                    }
                    else
                        MessageBox.Show("An another album have already this name !");
                }
                else
                    break;
            } while (this.photoViewer.getAlbum(dialog.getTextBox().Text) != null || dialog.getTextBox().Text.Equals(""));
            dialog.Dispose();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //select the item under the mouse pointer
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                {
                    listboxContextMenu.Show();
                }
            }
        }
    }
}
