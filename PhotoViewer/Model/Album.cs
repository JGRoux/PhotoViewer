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

        public static void WriteXml(List<Album> albums, String file)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            using (StreamWriter sw = new StreamWriter(file))
            {
                xs.Serialize(sw, albums);
            }
        }

        public static List<Album> ReadXml(String file)
        {
            List<Album> albums = null;
            XmlSerializer xs = new XmlSerializer(typeof(List<Albums>));
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    albums = xs.Deserialize(sr) as List<Album>;
                }
            }
            catch
            {
                albums = new List<Album>();
            }
            return albums;
        }
    }
}
