using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyPhotoViewer
{
    // Class representing  an album with its pictures and infos

    [Serializable()]
    public class Album
    {
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public List<Picture> PicturesList;

        public Album()
        {
            this.PicturesList = new List<Picture>();
        }

        public Album(String title, DateTime date):this()
        {
            this.Name=title;
            this.Date=date;
        }

        // Add a picture to the album
        public void addPicture(String pictureName){
            String path = "albums\\" + this.Name + "\\" + pictureName;
            this.PicturesList.Add(new Picture(pictureName,File.GetLastWriteTime(path), new FileInfo(path).Length));
        }

        // Remove a picture from the album
        public void removePicture(String name)
        {
            foreach (Picture picture in this.PicturesList){
                if (picture.Name.Equals(name))
                {
                    this.PicturesList.Remove(picture);
                    return;
                }
            }
        }

        // Get a picture from the album
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
