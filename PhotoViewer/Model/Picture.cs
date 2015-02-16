using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoViewer
{
    [Serializable()]
    public class Picture
    {
        public String Name { get; set; }
        public String Category { get; set; }
        public int Rating { get; set; }
        public String[] Keywords { get; set; }
        public String Path { get; set; }

        public Picture()
        {
            this.Keywords = new String[5];
        }

        public Picture(String Name):this()
        {
            this.Name = Name;
        }
    }
}
