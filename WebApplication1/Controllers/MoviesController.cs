using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        
        // GET: Movies
        [Route("Movies")]
        public ActionResult Index()
        {
            List<Movies> MoviesList = new List<Movies>();
            MoviesList.Add(new Movies(0, "Shrek", 10, 2010));
            MoviesList.Add(new Movies(1, "Finding nemo", 8, 2012));
            MoviesList.Add(new Movies(2, "Spartacus", 5, 2002));
            MoviesList.Add(new Movies(3, "Joker", 1, 2004));
            MoviesList.Add(new Movies(4, "Inception", 12, 2015));
            Session["list"] = MoviesList;
            var ListViewModel = new ListViewModel();
            ListViewModel.ListOfMovies = MoviesList;
            
            return View(ListViewModel);
        }
        [Route("Movies/Details/{movieID}")]
        public ActionResult Details(int movieID)
        {
            List<Movies> list = (List<Movies>)Session["list"];
            Movies movie;
            if(list != null)
            {
                movie = list[movieID];
            }
            else
            {
                movie = new Movies(12, "Error", 12, 2012);
            }
            return View(movie);
        }


    }
}