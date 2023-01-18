using Infinite.MVC.Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinite.MVC.Day1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context=null ;

        public ProductController()
        {
            _context=new ApplicationDbContext();
        }


        // GET: Product
        public ActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);

        }

        public ActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(product!=null) 
            {
                return View(product);
            }
            return HttpNotFound();
        }
        public ActionResult Create()
        {
           var categories = new List<Category>();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}