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
        public Album album {get; set;}

        public event EventHandler back;

        public UserControlPhoto(Album album, Picture picture)
        {
            InitializeComponent();
            this.album = album;
            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + picture.Name, true);

            this.panel2.Controls.Add(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            back(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public PictureBoxSizeMode Zoom { get; set; }
    }
}
