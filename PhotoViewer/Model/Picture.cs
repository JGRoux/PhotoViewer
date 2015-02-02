using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    [Serializable()]
    public class Picture
    {
        private String Category { get; set; }
        private int Rating { get; set; }
        private String[] Keywords { get; set; }

        public Picture()
        {
            this.Keywords = new String[5];
        }
    }
}
