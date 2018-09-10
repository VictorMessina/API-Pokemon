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

            List<Pokemon> AllPokemons = db.Pokemons.ToList();

            return ConvertDataToJson(AllPokemons);

        }

        // GET pokemon/AllRegions/
        [Route("pokemon/AllRegions")]
        [HttpGet]
        public HttpResponseMessage AllRegions()
        {

            List<Region> AllRegions = db.Regions.ToList();

            return ConvertDataToJson(AllRegions);

        }

        // GET pokemon/AllTypes/
        [Route("pokemon/AllTypes")]
        [HttpGet]
        public HttpResponseMessage AllTypes()
        {

            List<PokemonType> AllTypes = db.PokemonTypes.ToList();

            return ConvertDataToJson(AllTypes);

        }

        // GET pokemon/AllLegendaryPokemons
        [Route("pokemon/AllLegendaryPokemons")]
        [HttpGet]
        public HttpResponseMessage AllLegendaryPokemons()
        {

            List<Pokemon> AllLegendaryPokemons = db.Pokemons.Where(x => x.Legendary.Equals(true)).ToList();

            return ConvertDataToJson(AllLegendaryPokemons);

        }

        // GET pokemon/AllMythicalPokemons
        [Route("pokemon/AllMythicalPokemons")]
        [HttpGet]
        public HttpResponseMessage AllMythicalPokemons()
        {

            List<Pokemon> AllMythicalPokemons = db.Pokemons.Where(x => x.Mythical.Equals(true)).ToList();

            return ConvertDataToJson(AllMythicalPokemons);

        }

        // GET pokemon/PokemonByPodexNumber/PokedexNumber
        [Route("pokemon/PokemonByPodexNumber/{PokedexNumber:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonByPodexNumber(int PokedexNumber)
        {

            List<Pokemon> PokemonByPodexNumber = db.Pokemons.Where(x => x.NationalPokedexNumber == PokedexNumber).ToList();

            return ConvertDataToJson(PokemonByPodexNumber);

        }

        // GET pokemon/PokemonByName/Name
        [Route("pokemon/PokemonByName/{Name:length(1,15)}")]
        [HttpGet]
        public HttpResponseMessage PokemonByName(string Name)
        {

            List<Pokemon> PokemonByName = db.Pokemons.Where(x => x.Name.StartsWith(Name)).ToList();

            return ConvertDataToJson(PokemonByName);

        }

        // GET pokemon/PokemonsByGeneration/Generation
        [Route("pokemon/PokemonsByGeneration/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByGeneration(string Generation)
        {

            List<Pokemon> PokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).ToList();

            return ConvertDataToJson(PokemonsByGeneration);

        }

        // GET pokemon/LegendaryPokemonsByGeneration/Generation
        [Route("pokemon/LegendaryPokemonsByGeneration/{Generation:length(1,8)}/")]
        [HttpGet]
        public HttpResponseMessage LegendaryPokemonsByGeneration(string Generation)
        {

            List<Pokemon> LegendaryPokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).Where(x => x.Legendary.Equals(true)).ToList();

            return ConvertDataToJson(LegendaryPokemonsByGeneration);

        }

        // GET pokemon/MythicalPokemonsByGeneration/Generation
        [Route("pokemon/MythicalPokemonsByGeneration/{Generation:length(1,8)}/")]
        [HttpGet]
        public HttpResponseMessage MythicalPokemonsByGeneration(string Generation)
        {

            List<Pokemon> MythicalPokemonsByGeneration = db.Pokemons.Where(x => x.Generation.Equals(Generation)).Where(x => x.Mythical.Equals(true)).ToList();

            return ConvertDataToJson(MythicalPokemonsByGeneration);

        }

        // GET pokemon/PokemonsByTypeID/TypeID
        [Route("pokemon/PokemonsByTypeID/{TypeID:int}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeID(int TypeID)
        {

            List<Pokemon> PokemonsByTypeID = db.Pokemons.Where(x => x.PokemonTypeID == TypeID).ToList();

            return ConvertDataToJson(PokemonsByTypeID);

        }

        // GET pokemon/PokemonsByTypeIDAndGeneration/TypeID/Generation
        [Route("pokemon/PokemonsByTypeIDAndGeneration/{TypeID:int}/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeIDAndGeneration(int TypeID, string Generation)
        {

            List<Pokemon> PokemonsByTypeIDAndGeneration = db.Pokemons.Where(x => x.PokemonTypeID == TypeID).Where(x => x.Generation.Equals(Generation)).ToList();

            return ConvertDataToJson(PokemonsByTypeIDAndGeneration);

        }

        // GET pokemon/PokemonsByTypeName/TypeName
        [Route("pokemon/PokemonsByTypeName/{TypeName:length(1,17)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeName(string TypeName)
        {

            List<Pokemon> PokemonsByTypeName = db.Pokemons.Where(x => x.PokemonType.Description.Equals(TypeName)).ToList();

            return ConvertDataToJson(PokemonsByTypeName);

        }

        // GET pokemon/PokemonsByTypeNameAndGeneration/TypeName/Generation
        [Route("pokemon/PokemonsByTypeNameAndGeneration/{TypeName:length(1,17)}/{Generation:length(1,8)}")]
        [HttpGet]
        public HttpResponseMessage PokemonsByTypeNameAndGeneration(string TypeName, string Generation)
        {

            List<Pokemon> PokemonsByTypeNameAndGeneration = db.Pokemons.Where(x => x.PokemonType.Description.Equals(TypeName)).Where(x => x.Generation.Equals(Generation)).ToList();

            return ConvertDataToJson(PokemonsByTypeNameAndGeneration);

        }

        public HttpResponseMessage ConvertDataToJson<T>(List<T> GenericList)
        {
            HttpResponseMessage response;

            string JsonData = Newtonsoft.Json.JsonConvert.SerializeObject(new { GenericList });

            response = Request.CreateResponse(HttpStatusCode.OK);

            response.Content = new StringContent(JsonData, Encoding.UTF8, "application/json");

            return response;
        }
    }
}