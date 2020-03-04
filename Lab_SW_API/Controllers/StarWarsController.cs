using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab_SW_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_SW_API.Controllers
{
    public class StarWarsController : Controller
    {

        public async Task<IActionResult> GetPersonById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");


            var response = await client.GetAsync($"people/{id}");
            var character = await response.Content.ReadAsAsync<Result>();

            
            return View(character);

        }
        public async Task<IActionResult> GetPlanetById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");


            var response = await client.GetAsync($"planets/{id}");
            var planet = await response.Content.ReadAsAsync<Planet>();


            return View(planet);

        }
    }
}