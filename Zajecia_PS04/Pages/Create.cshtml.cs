using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia_PS04.Models;

namespace Zajecia_PS04.Pages
{
    public class CreateModel : MyPageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                LoadDB();
                productDB.Create(newProduct);
                SaveDB();
                return RedirectToPage("List");
            }
            return Page();
           
        }

    }
}
