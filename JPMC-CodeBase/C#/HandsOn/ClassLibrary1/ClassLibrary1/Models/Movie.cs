using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string language { get; set; }
        public int releaseDate { get; set; }
        public string actor { get; set; }
        public string director { get; set; }
    }
}
