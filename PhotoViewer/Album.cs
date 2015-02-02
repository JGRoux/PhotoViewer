using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    class Album
    {
        private String Title { get; set; }
        private String Subtitle { get; set; }
        private DateTime Date { get; set; }
        private String[] Keywords { get; set; }
        private List<Picture> PicturesList;

        public Album()
        {
            this.Keywords = new String[5];
            PicturesList = new List<Picture>();
        }
    }
}
