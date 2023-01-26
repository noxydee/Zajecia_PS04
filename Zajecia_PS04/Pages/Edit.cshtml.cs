using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia_PS04.Models;

namespace Zajecia_PS04.Pages
{
    public class EditModel : MyPageModel
    {
        public List<Product> ProductList;

        public Product EditProduct { get; set; }
        public int idx;

        public void OnGet(int id)
        {
            LoadDB();
            ProductList = productDB.List();
            SaveDB();
            
            foreach(Product x in ProductList)
            {
                if(x.id==id)
                {
                    EditProduct = x;
                    idx = id;
                }
            }
        }

        public IActionResult OnPost(Product EditProduct)
        {
            if(ModelState.IsValid)
            {
                LoadDB();
                LoadCart();
                productDB.Edit(EditProduct);
                ShopingCart.Edit(EditProduct);
                SaveCart();
                SaveDB();

                return RedirectToPage("List");
            }
            return Page();
            
        }





    }
}
