using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using BiteMeBurger.model;
using BiteMeBurger.services;

namespace BiteMeBurger.Pages
{
    public class BurgerListModel : PageModel
    {
        JsonBurgerFiless BurgerService;
         public IEnumerable<burger> Burgers;

        public BurgerListModel(JsonBurgerFiless burgerservice)
        {
            this.BurgerService = burgerservice;
        }
        public void OnGet()
        {
            Burgers = BurgerService.getBurgersData();
        }
    }
}
