using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace API_Pokemon.Models
{
    [Serializable]
    public class PokemonType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokemonTypeID { get; set; }

        [Required]
        public string Description { get; set; }

        [JsonIgnore]
        public virtual List<Pokemon> Pokemons { get; set; }
    }
}