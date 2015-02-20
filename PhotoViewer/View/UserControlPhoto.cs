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
        public int indice { get; set;}

        public event EventHandler back;

        public UserControlPhoto(Album album, int indice)
        {
            InitializeComponent();
            this.album = album;
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
            if(this.indice == 0)
            {
                this.indice = this.album.PicturesList.Count - 1;
            }
            else
            {
                this.indice--;
            }
            
            pictureBox1.Image = new Bitmap("albums\\" + this.album.Name + "\\" + this.album.PicturesList.ElementAt(indice).Name, true);
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
