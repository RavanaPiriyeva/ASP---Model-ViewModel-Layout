using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class FeatureController : Controller
    {
        public List<Feature> features = new List<Feature>
        {
          new Feature {Id = 1, Title="Lorem Ipsum",Descrition="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", Icon="bi bi-card-checklist"},
          new Feature {Id = 2, Title="Dolor Sitema",Descrition="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata", Icon="bi bi-bar-chart"},
          new Feature {Id = 3, Title="Sed ut perspiciatis",Descrition="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", Icon="bi bi-binoculars"},


        };
        public IActionResult Detail(int id)
        {
           
            Feature feature = features.Find(x => x.Id == id);
            ViewBag.feature = feature;
            return View();
        }
    }
}
