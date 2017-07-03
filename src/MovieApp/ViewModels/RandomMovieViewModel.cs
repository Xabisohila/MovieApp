using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movies { get; set; }
        public List<Customer>Customers { get; set; }
    }
}
