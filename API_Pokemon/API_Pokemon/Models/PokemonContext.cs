using System.Data.Entity;

namespace API_Pokemon.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext() : base("name=pokemon")
        {
        }

        public DbSet<Pokemon> Pokemons { get; set; }

        public DbSet<PokemonType> PokemonTypes { get; set; }

        public DbSet<Region> Regions { get; set; }
    }
}