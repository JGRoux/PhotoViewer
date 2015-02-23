using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyPhotoViewer.Controller;
using MyPhotoViewer.Model;

namespace MyPhotoViewer.View
{
    public partial class UserControlPictures : UserControl
    {
        private Album album;
        private int index;
        private int rating;
        private PhotoViewer photoViewer;

        public event EventHandler goBack;
        public event EventHandler startDiaporama;
        public Timer timer = new Timer();

        public UserControlPictures(PhotoViewer photoViewer, Album album, int index)
        {
            InitializeComponent();
            this.photoViewer = photoViewer;
            this.album = album;
            this.index = index;
        }

        // Call on load
        private void UserControlPictures_Load(object sender, EventArgs e)
        {

            // Set tooltip on mouse over
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnBack, "Back to the album");
            toolTip.SetToolTip(this.btnPreviousPicture, "Previous picture");
            toolTip.SetToolTip(this.btnNextPicture, "Next Picture");

            // Prepare timer for diaporama mode
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.btnNext_Click);

            this.setPicture();
        }

        // Click on back button event. Return to album miniatures.
        private void btnBack_Click(object sender, EventArgs e)
        {
            goBack(this, e);
        }

        // Click on previous picture button. Display previous picture.
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.previousPicture();
        }

        // Click on next picture button. Display next picture.
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.nextPicture();
        }

        // Display previous picture
        public void previousPicture()
        {
            // Change picture index
            if (this.index == 0)
                this.index = this.album.PicturesList.Count - 1;
            else
                this.index--;

            this.setPicture();
        }

        // Display next picture
        public void nextPicture()
        {
            // Change picture index
            this.index = (this.index + 1) % this.album.PicturesList.Count;
            this.setPicture();
        }

        // Set picture to picture box. Set picture infos.
        private void setPicture()
        {
            // Use filestream to unlock the file. Imperative to allow deleting file.
            using (FileStream fs = new FileStream("albums\\" + this.album.Name + "\\" + this.album.PicturesList.ElementAt(index).Name, FileMode.Open, FileAccess.Read))
            {
                Image img = Image.FromStream(fs);
                pictureBox.Image = img;
                this.lblPictureDimension.Text = img.Width.ToString() + " x " + img.Height.ToString();
            }

            // Set picture infos
            this.lblPictureName.Text = this.album.PicturesList.ElementAt(index).Name;
            this.lblPictureDate.Text = this.album.PicturesList.ElementAt(index).Date.ToString();
            this.lblPictureSize.Text = this.album.PicturesList.ElementAt(index).Size;
            this.txtBxPictureDescription.Text = this.album.PicturesList.ElementAt(index).Description;
            this.rating = this.album.PicturesList.ElementAt(index).Rating;
            this.setStars();
        }

        // Go to/Return from fullscreen mode. Hide/Show top/bottom panel.
        public void setFullScreen(bool choice)
        {
            if (choice)
            {
                this.panelTop.Hide();
                this.panelBottom.Hide();
                this.pictureBox.Dock = DockStyle.Fill;
                this.pictureBox.BackColor = Color.Black;
            }
            else
            {
                this.panelTop.Show();
                this.panelBottom.Show();
                this.pictureBox.Dock = DockStyle.Fill;
                this.pictureBox.BackColor = SystemColors.Control;
            }
        }

        // Double click event on pictureBox. Start diaporama.
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            startDiaporama(this, e);
        }

        // Mouse enter event on stars. Set number of star depending on mouse position.
        private void stars_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.star1))
                this.rating = 1;
            else if (sender.Equals(this.star2))
                this.rating = 2;
            else if (sender.Equals(this.star3))
                this.rating = 3;
            else if (sender.Equals(this.star4))
                this.rating = 4;
            else if (sender.Equals(this.star5))
                this.rating = 5;

            this.setStars();
        }

        // Mouse leave event on stars. Reset the number of stars to the original one.
        private void stars_MouseLeave(object sender, EventArgs e)
        {
            this.rating = this.album.PicturesList.ElementAt(index).Rating;
            this.setStars();
        }

        // Mouse click event on stars. Save the rating depending on the star clicked.
        private void stars_MouseClick(object sender, EventArgs e)
        {
            this.album.PicturesList.ElementAt(index).Rating = this.rating;
            this.photoViewer.save();
        }

        // Set yellow stars depending on the current rating (mouse position or original one)
        private void setStars()
        {
            if (this.rating >= 1)
                this.star1.Image = MyPhotoViewer.Properties.Resources.icon_yellow_star;
            else
                this.star1.Image = MyPhotoViewer.Properties.Resources.icon_empty_star;
            if (this.rating >= 2)
                this.star2.Image = MyPhotoViewer.Properties.Resources.icon_yellow_star;
            else
                this.star2.Image = MyPhotoViewer.Properties.Resources.icon_empty_star;
            if (this.rating >= 3)
                this.star3.Image = MyPhotoViewer.Properties.Resources.icon_yellow_star;
            else
                this.star3.Image = MyPhotoViewer.Properties.Resources.icon_empty_star;
            if (this.rating >= 4)
                this.star4.Image = MyPhotoViewer.Properties.Resources.icon_yellow_star;
            else
                this.star4.Image = MyPhotoViewer.Properties.Resources.icon_empty_star;
            if (this.rating >= 5)
                this.star5.Image = MyPhotoViewer.Properties.Resources.icon_yellow_star;
            else
                this.star5.Image = MyPhotoViewer.Properties.Resources.icon_empty_star;
        }

        // Text box picture description event on key down. Save picture description to xml on key enter.
        private void txtBxPictureDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.album.PicturesList.ElementAt(index).Description = this.txtBxPictureDescription.Text;
                this.photoViewer.save();
                this.txtBxPictureDescription.BackColor = SystemColors.Control;
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true; // Allow to suppress the 'ding' sound
            }
        }

        // Mouse enter event on text box description. Set background color to white.
        private void txtBxPictureDescription_MouseEnter(object sender, EventArgs e)
        {
            this.txtBxPictureDescription.BackColor = Color.White;
        }

        // Mouse enter event on text box description. Set background color to control.
        private void txtBxPictureDescription_MouseLeave(object sender, EventArgs e)
        {
            this.txtBxPictureDescription.BackColor = SystemColors.Control;
        }
    }
}
