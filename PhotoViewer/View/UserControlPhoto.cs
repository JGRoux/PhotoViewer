using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoViewer.View
{
    public partial class UserControlPhoto : UserControl
    {
        public Album album { get; set; }
        public int indice { get; set; }

        public event EventHandler back;

        public UserControlPhoto(Album album, int indice)
        {
            InitializeComponent();
            this.album = album;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.button1, "Back to the album");
            ToolTip toolTip2 = new ToolTip();
            toolTip2.SetToolTip(this.button2, "Previous picture");
            ToolTip toolTip3 = new ToolTip();
            toolTip3.SetToolTip(this.button3, "Next Picture");
            ToolTip toolTip4 = new ToolTip();
            toolTip4.SetToolTip(this.button4, "Information about this picture");
            ToolTip toolTip5 = new ToolTip();
            toolTip5.SetToolTip(this.button5, "Delete this picture");

            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + this.album.PicturesList.ElementAt(indice).Name, true);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public PictureBoxSizeMode Zoom { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.nextPicture();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.previousPicture();
        }

        private void nextPicture()
        {
            if (this.indice == 0)
            {
                this.indice = this.album.PicturesList.Count - 1;
            }
            else
            {
                this.indice--;
            }

            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + this.album.PicturesList.ElementAt(indice).Name, true);
        }

        private void previousPicture()
        {
            if (this.indice == this.album.PicturesList.Count - 1)
            {
                this.indice = 0;
            }
            else
            {
                this.indice++;
            }
            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + this.album.PicturesList.ElementAt(indice).Name, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                this.previousPicture();
                return true;    // indicate that you handled this keystroke
            }
            else if (keyData == Keys.Right)
            {
                this.nextPicture();
                return true;
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
