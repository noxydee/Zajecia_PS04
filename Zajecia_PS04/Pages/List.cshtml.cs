using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia_PS04.Models;

namespace Zajecia_PS04.Pages
{
    public class ListModel : MyPageModel
    {
        public List<Product> ProductList;

        public void OnGet()
        {
            LoadDB();
            ProductList = productDB.List();
            SaveDB();
        }

        public IActionResult Delete(int id)
        {
            LoadDB();
            productDB.Remove(id);
            SaveDB();
            return RedirectToPage("Create");
        }


    }
}
