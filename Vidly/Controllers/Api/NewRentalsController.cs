using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        public ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // Load customer + movie via the ids our Dto gives us - foreach of these add a 
            var customerInDb = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");

                movie.NumberAvailable--;

                var toRent = new Rental
                {
                    Customer = customerInDb,
                    DateRented = DateTime.Now,
                    Movie = movie
                };
                _context.Rentals.Add(toRent);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}