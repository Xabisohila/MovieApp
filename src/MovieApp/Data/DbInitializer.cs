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
                new Customer {FullName = "Hila Xabiso", Email= "okxabisohila@gmail.com" },
                new Customer {FullName="Moutzouris Yiota", Email="yiota.moutzouris@nmmu.ac.za" },
                new Customer {FullName="Hila Sima", Email="sima@yahoo.com" }
            };
            foreach (Customer cust in customers)
            {
                _context.Customers.Add(cust);
            }
            _context.SaveChanges();
        }
    }
}
