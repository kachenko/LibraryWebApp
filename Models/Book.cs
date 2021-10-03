using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibWebApp.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
    }
}