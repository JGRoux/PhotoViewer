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
    public partial class UserControlMiniatures : UserControl
    {
        ImageList imageList1 = new ImageList();
        ListView listView1 = new ListView();
        Album album; 
        public UserControlMiniatures(Album album)
        {
            InitializeComponent();

            this.album = album;

            foreach (Picture p in album.PicturesList)
            {
                imageList1.Images.Add(new Bitmap(p.Path, true));
                listView1.Items.Add(new ListViewItem());
            }

            listView1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(100, 100);
            this.panel1.Controls.Add(listView1);
        }

        private void listView1_DoubleClick(object sender, MouseEventArgs e)
        {
            this.Controls.Add(new UserControlPhoto(album.PicturesList.ElementAt(listView1.SelectedIndices[0])));
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
