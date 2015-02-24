using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhotoViewer.View
{
    // Window to get album name from user.
    public partial class DialogAlbumName : Form
    {
        public DialogAlbumName()
        {
            InitializeComponent();
        }

        public TextBox getTextBox(){
            return this.txtBxAlbumName;
        }
    }
}
