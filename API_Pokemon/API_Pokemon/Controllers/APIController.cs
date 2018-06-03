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

        // GET pokemon/PokemonByPodexNumber/PokedexNumber
        [Route("pokemon/PokemonByPodexNumber/{PokedexNumber:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonByPodexNumber(int PokedexNumber)
        {

            HttpResponseMessage response;

            List<Pokemon> Pokemon = db.Pokemons.Where(x => x.NationalPokedexNumber == PokedexNumber).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { Pokemon });

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

            List<Pokemon> Pokemon = db.Pokemons.Where(x => x.Name.StartsWith(Name)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { Pokemon });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonByGeneration/Generation
        [Route("pokemon/PokemonByGeneration/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonByGeneration(string Generation)
        {

            HttpResponseMessage response;

            List<Pokemon> Pokemons = db.Pokemons.Where(x => x.Generation.Equals(Generation)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { Pokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonByTypeID/TypeID
        [Route("pokemon/PokemonByTypeID/{TypeID:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonByTypeID(int TypeID)
        {

            HttpResponseMessage response;

            List<Pokemon> Pokemons = db.Pokemons.Where(x => x.PokemonTypeID == TypeID).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { Pokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }

        // GET pokemon/PokemonByTypeName/TypeName
        [Route("pokemon/PokemonByTypeName/{TypeName:length(1,17)}")]
        [HttpGet]
        public HttpResponseMessage PokemonByTypeName(string TypeName)
        {

            HttpResponseMessage response;

            List<Pokemon> Pokemons = db.Pokemons.Where(x => x.PokemonType.Description.Equals(TypeName)).ToList();

            string SuccessResponseJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { Pokemons });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(SuccessResponseJson, Encoding.UTF8, "application/json");

            return response;

        }
    }
}