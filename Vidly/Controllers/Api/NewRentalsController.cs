﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            //var newRental = new NewRentalDto();
            //newRental.CustomerId = 2;
            //newRental.MovieIds = new List<int> {2,3,4};

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie " + movie.Name + " is nor available.");

                movie.NumberAvailable--;

                var newItem = new Rentals
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now,
                };
                
                _context.Rentals.Add(newItem);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}