using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UpnoidContext _context)
        {
            _context.Database.EnsureCreated();

            //look for any customers
            if (_context.Customers.Any())
            {
                return;
            }

            //Creating customers
            var customers = new Customer[]
            {
                new Customer {Name = "Hila, Xabiso"}, //start here tommorrow

            };
        }
    }
}
