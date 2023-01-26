using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia_PS04.Models;

namespace Zajecia_PS04.Pages
{
    public class DeleteModel : MyPageModel
    {

        public IActionResult OnGet(int id)
        {
            LoadDB();
            productDB.Remove(id);
            SaveDB();

            LoadCart();
            ShopingCart.Remove(id);
            SaveCart();

            return RedirectToPage("List");
        }
    }
}
