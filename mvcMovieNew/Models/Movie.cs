using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcMovieNew.Models
{
    public class Movie
    {
        public int Id;
        public string Title;
        public string Director;
        public Movie() { }
        public Movie(int Id, string Title, string Director)
        {
            this.Id = Id;
            this.Title = Title;
            this.Director = Director;

        }
    }
}