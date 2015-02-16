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
        public UserControlPhoto(Picture photo)
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(photo.Path, true);
            pictureBox1.SizeMode = Zoom;
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
