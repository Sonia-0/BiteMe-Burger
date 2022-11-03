using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using BiteMeBurger.model;
using BiteMeBurger.services;

namespace BiteMeBurger.Controller
{
    [Route("[controller]")]
    public class FormHandlerController : ControllerBase
    {
        JsonBurgerFiless BurgerService;

        public FormHandlerController(JsonBurgerFiless burgerservice)
        {
            this.BurgerService = burgerservice;
        }

        [HttpGet]
       public  string Get(int id, string name,string image)
        {
            burger obj = new burger();
            obj.burger_id = id;
            obj.name = name;
            obj.image = image;

           IEnumerable<burger> burgersData= BurgerService.getBurgersData();
           List<burger> listofburgers= burgersData.ToList();
            listofburgers.Add(obj);
           return  JsonSerializer.Serialize<List<burger>>(listofburgers);
        }
    }


}
