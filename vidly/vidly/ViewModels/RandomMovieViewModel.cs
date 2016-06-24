using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Controllers;
using vidly.Models;

namespace vidly.Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}