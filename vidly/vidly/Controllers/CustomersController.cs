using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
       public List<Customers> customers = new List<Customers> { new Customers { Name = "john", Id = 4 }, new Customers { Name = "Jane", Id = 5 }, new Customers { Name = "Dean", Id = 2 } }; 
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customers customer = customers.Find(x => x.Id == id);
            
            return View(customer);
        }
    }
}