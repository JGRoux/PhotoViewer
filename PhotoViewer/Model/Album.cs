using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoViewer
{
    [Serializable()]
    public class Album
    {
        public String Name { get; set; }
        public String Subtitle { get; set; }
        public DateTime Date { get; set; }
        public String[] Keywords { get; set; }
        public List<Picture> PicturesList;

        public Album()
        {
            this.PicturesList = new List<Picture>();
            this.Keywords = new String[5];
        }

        public Album(String Title, String Subtitle, DateTime Date):this()
        {
            this.Name=Title;
            this.Subtitle=Subtitle;
            this.Date=Date;
        }

        public void addPicture(String name){
            this.PicturesList.Add(new Picture(name));
        }

        public Picture getPicture(String name)
        {
            foreach (Picture picture in this.PicturesList)
            {
                if (picture.Name.Equals(name))
                    return picture;
            }
            return null;
        }
    }
}
