using Microsoft.AspNetCore.Mvc;
using MoviesPlatform.Models;
using MoviesPlatform.ViewModels;

namespace MoviesPlatform.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
        }
    }
}
