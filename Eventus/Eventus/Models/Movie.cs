using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventus.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDAte { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}