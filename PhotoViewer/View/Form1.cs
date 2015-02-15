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
        private PhotoViewer photoViewer;

        public MainWindow()
        {
            InitializeComponent();
            this.photoViewer = new PhotoViewer();
            foreach (Album album in this.photoViewer.AlbumsList)
            {
                this.listBox1.Items.Add(album.Title);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

            // Show testDialog as a modal dialog and determine if DialogResult = OK. 
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox. 
                this.listBox1.Items.Add(dialog.getTextBox().Text);
                this.photoViewer.addAlbum(dialog.getTextBox().Text, dialog.getTextBox().Text,DateTime.Now);
                this.photoViewer.save();
            }
            dialog.Dispose();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
