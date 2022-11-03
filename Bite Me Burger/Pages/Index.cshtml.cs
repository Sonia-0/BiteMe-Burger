using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiteMeBurger.model;
using BiteMeBurger.services;

namespace BiteMeBurger.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<burger> Burgers { get; private set; }
        public JsonBurgerFiless BurgerService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonBurgerFiless burgerService)
        {
            _logger = logger;
            BurgerService = burgerService;
        }

        public void OnGet()
        {

        }

    }
}

