using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.Rating = aRating;
        }

        public string Rating
        {
            get { return this.rating; }
            set
            {
                if(value=="G"|| value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    this.rating = "NR";
                }
            }
        }
    }
}
