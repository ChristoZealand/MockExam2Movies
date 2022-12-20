using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class MovieClass
    {
        public MovieClass(int id, string movieName, int lenghtInMinutes, string countryOfOrigin)
        {
            Id = id;
            MovieName = movieName;
            LenghtInMinutes = lenghtInMinutes;
            CountryOfOrigin = countryOfOrigin;
        }

        public MovieClass()
        {

        }

        public int Id { get; set; }
        public string MovieName { get; set; }    
        public int LenghtInMinutes { get; set; }
        public string CountryOfOrigin { get; set; }

    }
}
