using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyPhotoViewer.Controller
{
    // Class to transform user control pictures to diaporama in fullscreen
    class Diaporama
    {
        private FormWindowState winState;
        private FormBorderStyle brdStyle;
        private bool topMost;
        private Rectangle bounds;
        private Form targetForm;
        public bool IsFullScreen { get; set; }

        public Diaporama(Form targetForm)
        {
            this.targetForm = targetForm;
            this.IsFullScreen = false;
        }

        // Set/Quit fullscreen mode
        public void setFullScreen(bool choice)
        {
            if (choice)
            {
                // Save window states
                this.winState = this.targetForm.WindowState;
                this.brdStyle = this.targetForm.FormBorderStyle;
                this.topMost = this.targetForm.TopMost;
                this.bounds = this.targetForm.Bounds;

                // Set fullscreen properties
                this.targetForm.FormBorderStyle = FormBorderStyle.None;
                this.targetForm.WindowState = FormWindowState.Maximized;
                this.targetForm.TopMost = true;
                this.targetForm.Bounds = Screen.GetBounds(targetForm);
                this.IsFullScreen = true;
            }
            else
            {
                // Restore the original Window state.
                this.targetForm.WindowState = this.winState;
                this.targetForm.FormBorderStyle = this.brdStyle;
                this.targetForm.TopMost = this.topMost;
                this.targetForm.Bounds = this.bounds;
                this.IsFullScreen = false;
            }
        }
    }
}
