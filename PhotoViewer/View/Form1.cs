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
            this.listboxContextMenu = new ContextMenuStrip();
            this.listboxContextMenu.Opening += new CancelEventHandler(listboxContextMenu_Opening);
            this.listboxContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(listboxContextMenu_ItemClicked);
            this.listBox1.ContextMenuStrip = listboxContextMenu;
            this.photoViewer = new PhotoViewer();
            foreach (Album album in this.photoViewer.AlbumsList)
            {
                this.listBox1.Items.Add(album.Name);
            }
        }

        private void listboxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            //clear the menu and add custom items
            // listBox1.SelectedItem.ToString()
            if (this.listBox1.SelectedIndex != -1)
            {
                this.listboxContextMenu.Items.Clear();
                this.listboxContextMenu.Items.Add("Rename");
                this.listboxContextMenu.Items.Add("Delete");
            }
        }

        private void listboxContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if (e.ClickedItem.ToString().Equals("Rename"))
            {
                System.Console.WriteLine(e.ClickedItem);
                DialogAlbumName dialog = new DialogAlbumName();
                dialog.getTextBox().Text = this.listBox1.SelectedItem.ToString();
                if (dialogCompute(dialog))
                {
                    System.IO.Directory.Move("albums\\" + this.listBox1.SelectedItem.ToString(), "albums\\" + dialog.getTextBox().Text);
                    this.photoViewer.getAlbum(this.listBox1.SelectedItem.ToString()).Name = dialog.getTextBox().Text;
                    this.photoViewer.save();
                    int index = this.listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(index);
                    listBox1.Items.Insert(index, dialog.getTextBox().Text);
                }
                dialog.Dispose();
            }
            else if (e.ClickedItem.ToString().Equals("Delete"))
            {
                System.IO.Directory.Delete("albums\\" + this.listBox1.SelectedItem.ToString(), true);
                this.photoViewer.delAlbum(this.listBox1.SelectedItem.ToString());
                this.photoViewer.save();
                this.listBox1.Items.Remove(this.listBox1.SelectedItem);
                this.splitContainer1.Panel2.Controls.Clear();
            }
        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            DialogAlbumName dialog = new DialogAlbumName();
            if (dialogCompute(dialog))
            {
                this.listBox1.Items.Add(dialog.getTextBox().Text);
                System.IO.Directory.CreateDirectory("albums\\" + dialog.getTextBox().Text);
                this.photoViewer.addAlbum(dialog.getTextBox().Text, dialog.getTextBox().Text, DateTime.Now);
                this.photoViewer.save();
            }
            dialog.Dispose();

        }

        private Boolean dialogCompute(DialogAlbumName dialog)
        {
            do
            {
                // Show testDialog as a modal dialog and determine if DialogResult = OK. 
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    // 2 albums can't have the same name
                    if (dialog.getTextBox().Text.Equals(""))
                        MessageBox.Show("Please enter a name !");
                    else if (this.photoViewer.getAlbum(dialog.getTextBox().Text) == null)
                    {
                        return true;
                    }
                    else
                        MessageBox.Show("An another album have already this name !");
                }
                else
                    return false;
            } while (this.photoViewer.getAlbum(dialog.getTextBox().Text) != null || dialog.getTextBox().Text.Equals(""));
            return false;
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

            if (e.Button == MouseButtons.Left)
            {
                if (listBox1.SelectedIndex != -1)
                    this.splitContainer1.Panel2.Controls.Add(new UserControlMiniatures(this.photoViewer, this.photoViewer.getAlbum(listBox1.SelectedItem.ToString())));
            }
        }
    }
}
