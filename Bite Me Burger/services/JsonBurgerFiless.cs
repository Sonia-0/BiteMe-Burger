using Microsoft.AspNetCore.Hosting;
using BiteMeBurger.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using BiteMeBurger.model;

namespace BiteMeBurger.services
{
    public class JsonBurgerFiless
    {
        public JsonBurgerFiless(IWebHostEnvironment webHostEnvironment)
        {

            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "burger.json");
            }
        }

        public IEnumerable<burger> getBurgersData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<burger[]>(json_file.ReadToEnd());
            }

        }

        
    }  
}
