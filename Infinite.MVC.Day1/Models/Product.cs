using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Infinite.MVC.Day1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Product Name Cannont be Empty")]
        [Display(Name ="Product Name")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="Product Price")]
        [Range(0,100000.0, ErrorMessage ="Price Should be between 0 and 100000")]
        public double Price { get; set; }
        [Required]
        [Range(0,int.MaxValue,ErrorMessage ="Quantity should be greater than Zero")]
        public int Quantity { get; set; }

        //Navigation Properties
        public Category Category { get; set; }//This is not a column

        //Foreign Key
        public int categoruId { get; set; }
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 10832,ProductName="Pen",Price=59, Quantity=100 },
                new Product { Id = 1034,ProductName="Pencil",Price=59, Quantity=60 },
                new Product { Id = 101,ProductName="Penpencil",Price=59, Quantity=45 },
                new Product { Id = 10,ProductName="Colors",Price=59, Quantity=90 }
             
            };
        }
    }
}