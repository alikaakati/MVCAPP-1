using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Movies
    {
        public int movieID { get; set; }
        public string name { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public Movies(int movieID,string name,int month,int year)
        {
            this.movieID = movieID;
            this.name = name;
            this.month = month;
            this.year = year;
        }
    }
}