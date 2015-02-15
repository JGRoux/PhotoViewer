﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotoViewer
{
    [Serializable()]
    public class Album
    {
        public String Title { get; set; }
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
            this.Title=Title;
            this.Subtitle=Subtitle;
            this.Date=Date;
        }

        public void addPicture(String name){
            this.PicturesList.Add(new Picture(name));
        }

        public Picture getPicture(int nb)
        {
            return this.PicturesList.ElementAt(nb);
        }
    }
}
