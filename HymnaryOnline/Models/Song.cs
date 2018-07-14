using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HymnaryOnline.Models
{
    public class Song
    {
        public string Lyrics { get; set; }
        public string Title { get; set; }
        public string Piano { get; set; }
        public string Violin { get; set; }
        public string Clarinet { get; set; }
        public string Guitar { get; set; }
    }
}