using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using Infinite.MVC.Day1.Models;

namespace Infinite.MVC.Day1.Controllers
{
    //[RoutePrefix("Customers")]
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            Customer customer = new Customer();
            List<Customer> customers = customer.GetCustomers();
            //ViewBag.Myname = "Pooja Reddy";
            return View(customers);
        }
       
        //Customers/Details/1
        public ActionResult Details(int id )
        {
            Customer customerobj = new Customer();
            var customer = customerobj.GetCustomers().FirstOrDefault(c=>c.Id == id);
            if (customer != null)
            {
                return View(customer);
            }
            return HttpNotFound();
        }

        public ActionResult MyOrders(int id)
        {
            Product p = new Product();
            MyOrderDetailsViewModel vm = new MyOrderDetailsViewModel();
            vm.CustomerName = new Customer().GetCustomers().FirstOrDefault(c => c.Id == id).Name;
           
                //Products = new Product().GetProducts()
                if (vm.CustomerName == null)
            {
                return HttpNotFound("Customer Id does not exist");
            }
            vm.Products = p.GetProducts();
                                
                return View(vm);
        }

        //public ActionResult GetCustomers()
        //{
        //    return View();
        //}

        //    //Customers/GetCustomer/1001

        //    public ActionResult GetCustomer(int? id)
        //    {
        //        if (id.HasValue)
        //        {
        //            return Content($"Customer Id: {id}");
        //        }
        //        else
        //        {
        //            return new HttpNotFoundResult();
        //        }
        //    }
        //    //Customers/GetCustomerByIdAndName/84728/Pooja
        //    [Route("customers/GetCustomerByIdAndName/{id}/{name}")]
        //    public ActionResult GetCustomerByIdAndName(int? id, string name)
        //    {
        //        if(id.HasValue || !string.IsNullOrEmpty(name))
        //        {
        //            return Content($"Id:{id} \n Name:{name}");
        //        }
        //        else
        //        {
        //            return Content("Please provide Id or Name");
        //        }
        //    }

        //    //Customers/GetCustomerByName/Pooja
        //    [Route("customers/GetCustomerByName/{name}")]

        //    public ActionResult GetCustomerByName(string name)
        //    {
        //        if (!string.IsNullOrWhiteSpace(name))
        //        {
        //            return Content($"Welcome,{name}");
        //        }
        //        else
        //        {
        //            return Content("No Name Provided");
        //        }
        //    }


    }
}