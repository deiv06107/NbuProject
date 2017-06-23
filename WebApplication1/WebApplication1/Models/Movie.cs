using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Lenght { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string UserId { get; set; }

    }
}


