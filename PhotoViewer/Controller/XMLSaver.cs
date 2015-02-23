using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyPhotoViewer.Controller
{
    class XMLSaver
    {
        private static String filename = "infos.xml";

        // Write album list to xml file
        public static void WriteXml(List<Album> albums)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            using (StreamWriter sw = new StreamWriter(filename))
            {
                xs.Serialize(sw, albums);
            }
        }

        // Read xml file and return album list
        public static List<Album> ReadXml()
        {
            List<Album> albums = null;
            XmlSerializer xs = new XmlSerializer(typeof(List<Album>));
            try
            {
                using (StreamReader sr = new StreamReader(filename))
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
