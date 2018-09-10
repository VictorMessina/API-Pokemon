using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using API_Pokemon.Models;
using PagedList;

namespace API_Pokemon.Controllers
{
    public class HomeController : Controller
    {

        private PokemonContext db = new PokemonContext();

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult AllPokemons(string searchBy, string search, int? page)
        {
            if (searchBy == "ID" && search != "")
            {
                return View("AllPokemons", db.Pokemons.Where(x => x.NationalPokedexNumber.ToString() == search || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Name" && search != "")
            {
                return View("AllPokemons", db.Pokemons.Where(x => x.Name.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Region" && search != "")
            {
                return View("AllPokemons", db.Pokemons.Where(x => x.Region.Description.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Generation" && search != "")
            {
                return View("AllPokemons", db.Pokemons.Where(x => x.Generation.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "typeName" && search != "")
            {
                return View("AllPokemons", db.Pokemons.Where(x => x.PokemonType.Description.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else
            {
                return View("AllPokemons", db.Pokemons.ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
        }

        public ActionResult AllLegendaryPokemons(string searchBy, string search, int? page)
        {
            if (searchBy == "ID" && search != "")
            {
                return View("AllLegendaryPokemons", db.Pokemons.Where(x => x.Legendary.Equals(true) && x.NationalPokedexNumber.ToString() == search || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Name" && search != "")
            {
                return View("AllLegendaryPokemons", db.Pokemons.Where(x => x.Legendary.Equals(true) && x.Name.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Region" && search != "")
            {
                return View("AllLegendaryPokemons", db.Pokemons.Where(x => x.Legendary.Equals(true) && x.Region.Description.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Generation" && search != "")
            {
                return View("AllLegendaryPokemons", db.Pokemons.Where(x => x.Legendary.Equals(true) && x.Generation.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else
            {
                return View("AllLegendaryPokemons", db.Pokemons.Where(x => x.Legendary.Equals(true)).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
        }

        public ActionResult AllMythicalPokemons(string searchBy, string search, int? page)
        {
            if (searchBy == "ID" && search != "")
            {
                return View("AllMythicalPokemons", db.Pokemons.Where(x => x.Mythical.Equals(true) && x.NationalPokedexNumber.ToString() == search || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Name" && search != "")
            {
                return View("AllMythicalPokemons", db.Pokemons.Where(x => x.Mythical.Equals(true) && x.Name.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Region" && search != "")
            {
                return View("AllMythicalPokemons", db.Pokemons.Where(x => x.Mythical.Equals(true) && x.Region.Description.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else if (searchBy == "Generation" && search != "")
            {
                return View("AllMythicalPokemons", db.Pokemons.Where(x => x.Mythical.Equals(true) && x.Generation.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
            else
            {
                return View("AllMythicalPokemons", db.Pokemons.Where(x => x.Mythical.Equals(true)).ToList().ToPagedList(page ?? 1, 5)); // If page is null set the value to 1 /number of results per page
            }
        }
    }
}
