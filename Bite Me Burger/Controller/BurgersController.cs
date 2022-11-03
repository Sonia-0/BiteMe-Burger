using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BiteMeBurger.model;
using BiteMeBurger.services;

namespace BiteMeBurger.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        JsonBurgerFiless BurgerService { get; }
        public BurgersController(JsonBurgerFiless burgerservice)
        {
            this.BurgerService= burgerservice;
        }

        public IEnumerable<burger> Get()
        {
           return  BurgerService.getBurgersData();
        }
    }
}
