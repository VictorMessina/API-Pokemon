using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using API_Pokemon.Models;

namespace API_Pokemon.Controllers
{
    public class APIController : ApiController
    {
        PokemonContext db = new PokemonContext();

        // GET pokemon/AllPokemons/
        [Route("pokemon/AllPokemons")]
        [HttpGet]
        public HttpResponseMessage AllPokemons()
        {

            HttpResponseMessage response;

            List<Pokemon> AllPokemons = db.Pokemons.ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { AllPokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/AllRegions/
        [Route("pokemon/AllRegions")]
        [HttpGet]
        public HttpResponseMessage AllRegions()
        {

            HttpResponseMessage response;

            List<Region> AllRegions = db.Regions.ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { AllRegions });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/AllTypes/
        [Route("pokemon/AllTypes")]
        [HttpGet]
        public HttpResponseMessage AllTypes()
        {

            HttpResponseMessage response;

            List<PokemonType> AllTypes = db.PokemonTypes.ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { AllTypes });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

		// GET pokemon/AllLegendaryPokemons
        [Route("pokemon/AllLegendaryPokemons")]
        [HttpGet]
        public HttpResponseMessage AllLegendaryPokemons()
        {

            HttpResponseMessage response;

            List<Pokemon> AllLegendaryPokemons = db.Pokemons.Where(x => x.Legendary.Equals(true)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { AllLegendaryPokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/AllMythicalPokemons
        [Route("pokemon/AllMythicalPokemons")]
        [HttpGet]
        public HttpResponseMessage AllMythicalPokemons()
        {

            HttpResponseMessage response;

            List<Pokemon> AllMythicalPokemons = db.Pokemons.Where(x => x.Mythical.Equals(true)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { AllMythicalPokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonByPodexNumber/PokedexNumber
        [Route("pokemon/PokemonByPodexNumber/{PokedexNumber:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonByPodexNumber(int PokedexNumber)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonByPodexNumber = db.Pokemons.Where(x => x.NationalPokedexNumber == PokedexNumber).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonByPodexNumber });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonByName/Name
        [Route("pokemon/PokemonByName/{Name:length(1,15)}")]
        [HttpGet]
        public HttpResponseMessage PokemonByName(string Name)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonByName = db.Pokemons.Where(x => x.Name.StartsWith(Name)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonByName });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonsByGeneration/Generation
        [Route("pokemon/PokemonsByGeneration/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByGeneration(string Generation)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonsByGeneration });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/LegendaryPokemonsByGeneration/Generation
        [Route("pokemon/LegendaryPokemonsByGeneration/{Generation:length(1,8)}/")]
        [HttpGet]
        public HttpResponseMessage LegendaryPokemonsByGeneration(string Generation)
        {

            HttpResponseMessage response;

            List<Pokemon> LegendaryPokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).Where(x => x.Legendary.Equals(true)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { LegendaryPokemonsByGeneration });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/MythicalPokemonsByGeneration/Generation
        [Route("pokemon/MythicalPokemonsByGeneration/{Generation:length(1,8)}/")]
        [HttpGet]
        public HttpResponseMessage MythicalPokemonsByGeneration(string Generation)
        {

            HttpResponseMessage response;

            List<Pokemon> MythicalPokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).Where(x => x.Mythical.Equals(true)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { MythicalPokemonsByGeneration });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonsByTypeID/TypeID
        [Route("pokemon/PokemonsByTypeID/{TypeID:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeID(int TypeID)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonsByTypeID = db.Pokemons.Where(x => x.PokemonTypeID == TypeID).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonsByTypeID });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonsByTypeIDAndGeneration/TypeID/Generation
        [Route("pokemon/PokemonsByTypeIDAndGeneration/{TypeID:int}/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeIDAndGeneration(int TypeID, string Generation)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonsByTypeIDAndGeneration = db.Pokemons.Where(x => x.PokemonTypeID == TypeID).Where(x => x.Generation.Equals(Generation)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonsByTypeIDAndGeneration });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonsByTypeName/TypeName
        [Route("pokemon/PokemonsByTypeName/{TypeName:length(1,17)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeName(string TypeName)
        {

            HttpResponseMessage response;

            List<Pokemon> PokemonsByTypeName = db.Pokemons.Where(x => x.PokemonType.Description.Equals(TypeName)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { PokemonsByTypeName });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }
    }
}