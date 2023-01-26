using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia_PS04.Models;
using Zajecia_PS04.DAL;

namespace Zajecia_PS04.Pages
{
    public class DetailsModel : MyPageModel
    {
        public List<Product> ProductList;
        public Product DetailProduct { get; set; }

        

        public void OnGet(int id)
        {
            LoadDB();
            ProductList = productDB.List();
            SaveDB();

            foreach (Product x in ProductList)
            {
                if (x.id == id)
                {
                    DetailProduct = x;
                }
            }

        }

        public IActionResult OnPost(Product DetailProduct)
        {
            LoadCart();
            ShopingCart.CreateToCart(DetailProduct);
            SaveCart();

            return RedirectToPage("Cart");
        }

        
    }
}
