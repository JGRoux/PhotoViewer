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
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }
        public String Size { get; set; }

        public Picture()
        {
           
        }

        public Picture(String name, DateTime date, long size)
        {
            this.Name = name;
            this.Date = date;
            this.Size = this.computedSize(size);
        }
        
        // If necessary, transform picture size to KB or MB in a string format
        public String computedSize(long size){
            if (size > 1000000)
                return ((int)(size / 1000000)).ToString() + " MB";
            else if (size > 1000)
                return ((int)(size / 1000)).ToString() + " KB";
            else
                return size.ToString()+" B";
        }
    }
}
