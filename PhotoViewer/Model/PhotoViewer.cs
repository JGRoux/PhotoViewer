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

        // Add album to the photoviewer
        public void addAlbum(String name, DateTime date)
        {
            this.AlbumsList.Add(new Album(name, date));
        }

        // Delete album from the photoviewer
        public void delAlbum(String name)
        {
            this.AlbumsList.Remove(this.getAlbum(name));
        }

        // Get album from the photoviewer
        public Album getAlbum(String title)
        {
            foreach (Album album in this.AlbumsList)
            {
                if (album.Name.Equals(title))
                    return album;
            }
            return null;
        }

        // Save photoviewer album list to xml file
        public void save()
        {
            XMLSaver.WriteXml(this.AlbumsList);
        }
    }
}
