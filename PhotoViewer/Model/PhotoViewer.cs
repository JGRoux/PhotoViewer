using MyPhotoViewer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoViewer.Model
{
    public class PhotoViewer
    {
        public List<Album> AlbumsList;

        public PhotoViewer()
        {
            this.AlbumsList = XMLSaver.ReadXml();
        }

        public void addAlbum(String name, String subtitle, DateTime date){
            this.AlbumsList.Add(new Album(name,subtitle,date)); 

        }

        public Album getAlbum(String title)
        {
            //if(this.AlbumsList.ElementAt(0).Name != null)
            //{
                foreach (Album album in this.AlbumsList)
                {
                    if (album.Name.Equals(title))
                        return album;
                }
            //}
            
            return null;
        }

        public void save()
        {
            XMLSaver.WriteXml(this.AlbumsList);
        }
    }
}
