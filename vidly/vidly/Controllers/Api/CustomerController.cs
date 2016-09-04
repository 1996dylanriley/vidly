using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using vidly.Models;

namespace vidly.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
         
        //GET /api/customers
        public IEnumerable<Customers> GetCustomers()
        {

            return _context.Customers.ToList();
        }

        // Get /api/customers/1
        public Customers GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotAcceptable);
            return customer;
        }

        // POST /api/customers]
        [HttpPost]
        public Customers CreateCustomer(Customers customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }
    }
}
