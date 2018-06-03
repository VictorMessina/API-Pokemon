using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace API_Pokemon.Models
{
    [Serializable]
    public class Pokemon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PokemonID { get; set; }

        [Required]
        public int NationalPokedexNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Generation { get; set; }

        [Required]
        public bool Evolve { get; set; }

        [Required]
        public bool Legendary { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public int RegionID { get; set; }

        [JsonIgnore]
        public virtual Region Region { get; set; }

        [Required]
        public int PokemonTypeID { get; set; }

        [JsonIgnore]
        public virtual PokemonType PokemonType { get; set; }
    }
}