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
        PictureBox pictureBox1 = new PictureBox();
        Album album;

        public UserControlPhoto(Album album, Picture picture)
        {
            InitializeComponent();
            this.album = album;
            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + picture.Name, true);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public PictureBoxSizeMode Zoom { get; set; }
    }
}
