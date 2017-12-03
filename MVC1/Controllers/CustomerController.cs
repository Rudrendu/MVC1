using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(GetCustomers());
        }
        public ActionResult Detail(int id)
        {
            IEnumerable<Customer> Customers = GetCustomers();
            return View("Detail",Customers.Where(c=>c.ID==id).First());
        }
        private IEnumerable<Customer> GetCustomers()
        {
            List<Customer> Customers = new List<Customer>();
            Customers.Add(new Customer { ID = 1, Name = "Rudrendu Roy" });
            Customers.Add(new Customer { ID = 2, Name = "Pratyusha Dey" });
            return Customers;
        }
    }
}