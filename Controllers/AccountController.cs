using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppRoutingHelpers.Models;

namespace WebAppRoutingHelpers.Controllers
{
    public class AccountController : Controller
    {
        List<Country> CountryList;

        List<City> CityList;

        public AccountController()
        {

            CountryList = new List<Country>()
            {
                new Country(){CountryId=1, CountryName="India"},
                new Country (){ CountryId=2, CountryName="New Zealand"}
            };

            CityList = new List<City>()
            {
                new City(){CityId=1, CityName="Delhi", CountryId=1},
                new City(){CityId=2, CityName="Bangalore", CountryId=1},
                new City(){CityId=3, CityName="Auckland", CountryId=2},
                new City(){CityId=4, CityName="Hamilton", CountryId=2}
            };

        }
        
 
        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.CountryList = new SelectList(CountryList, "CountryId", "CountryName");
            ViewData["Gender"] = new List<string>()
            {
                new string("Male"),
                new string("Female"),
            };

            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            
            if (ModelState.IsValid)
            {
                return RedirectToAction("DisplayMessage", "Account");
            }
            return View();
        }
        public IActionResult DisplayMessage()
        {
            return View();
        }
        public JsonResult getCity(int CountryId)
        {
            List<City> Cities = CityList.FindAll(x => x.CountryId == CountryId);
            return new JsonResult(Cities);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            return View();
        }

    }
}
