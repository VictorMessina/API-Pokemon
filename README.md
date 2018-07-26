# API - Pokemon

This project is about things that are special to me, like my favorite anime and learn a new programming language, in that case [C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/) with [EntityFramework](https://docs.microsoft.com/en-us/ef/core/).

The purpose of this initiative is to provide an API REST that will allow users to get all kinds of information about the anime.

# Tech Sources

* [Visual Studio 2017](https://visualstudio.microsoft.com/pt-br/downloads/)
* [SQL Server 2017](https://www.microsoft.com/pt-pt/sql-server/sql-server-downloads)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/)
* [ASP.NET](https://www.asp.net/)
* [.NET](https://www.microsoft.com/net/learn/get-started/windows)
* [EntityFramework](https://docs.microsoft.com/en-us/ef/core/).
* [Postman](https://www.getpostman.com/apps)
* [DB Designer](https://sourceforge.net/projects/dbdesigner-fork/)

# Data Sources

* [Pokemon](https://www.pokemon.com/us/pokedex/)
* [Pokemondb](https://pokemondb.net/pokedex/national)
* [Bulbapedia Legendary Pokemons](https://bulbapedia.bulbagarden.net/wiki/Legendary_Pok%C3%A9mon)
* [Bulbapedia Mythical Pokemons](https://bulbapedia.bulbagarden.net/wiki/Mythical_Pokémon)
* [Mythical Pokemon part 1](https://www.pokemon.com/us/strategy/mythical-pokemon-distribution-round-up-part-1/)
* [Mythical Pokemon part 2](https://www.pokemon.com/us/strategy/mythical-pokemon-distribution-round-up-part-2/)
* [Mythical Pokemon part 3](https://www.pokemon.com/us/strategy/mythical-pokemon-distribution-round-up-part-3/)
* [Mythical Pokemon part 4](https://www.pokemon.com/us/strategy/mythical-pokemon-distribution-round-up-part-4/)

# Routes

| Routes                                        | Description                                    | Methods HTTP     | Params and type  |
|-----------------------------------------------|------------------------------------------------|------------------|------------------|
| /pokemon/AllPokemons                          | return all pokemons of the anime		         | GET              |Don't need		   |
| /pokemon/AllTypes                             | return all types of pokemons					 | GET              |Don't need		   |
| /pokemon/AllRegions                           | return all regions 						     | GET              |Don't need		   |
| /pokemon/AllLegendaryPokemons                 | return all legendary pokemons the anime        | GET              |Don't need		   |
| /pokemon/AllMythicalPokemons					| return all mythical pokemons the anime		 | GET				|Don't need		   |
| /pokemon/PokemonByPodexNumber/#PokedexNumber  | return a specific pokemon                      | GET              |PokedexNumber: int|
| /pokemon/PokemonByName/#Name                  | return a specific pokemon or all pokemons starts with that words  | GET |Name: string|
| /pokemon/PokemonsByGeneration/#Generation     | return all pokemons of a specific generation   | GET              |Generation: string|
| /pokemon/LegendaryPokemonsByGeneration/#Generation| return all legendary pokemons by a specific generation | GET	|Generation: string|
| /pokemon/MythicalPokemonsByGeneration/#Generation| return all mythical pokemons by a specific generation | GET	|Generation: string|
| /pokemon/PokemonsByTypeID/#TypeID             | return all pokemons of a specific type ID      | GET              |TypeID: int	   |
| /pokemon/PokemonsByTypeIDAndGeneration/#TypeID/#Generation | return all pokemons of a specific typeID and a specific generation| GET |TypeID: int and Generation: string|
| /pokemon/PokemonsByTypeName/#TypeName			| return all pokemons of a specific type name    | GET				|TypeName: string  |
| /pokemon/PokemonsByTypeNameAndGeneration/#TypeName/#Generation| return all pokemons of a specific typeName and a specific generation | GET |TypeName: string and Generation: string|

## Example
#### /pokemon/PokemonByPodexNumber/25
```json
{
    "Pokemon": [
        {
            "PokemonID": 25,
            "NationalPokedexNumber": 25,
            "Name": "Pikachu",
            "Generation": "First",
            "Evolve": true,
            "Legendary": false,
            "Mythical": false,
            "Image": "https://assets.pokemon.com/assets/cms2/img/pokedex/detail/025.png",
            "RegionID": 1,
            "PokemonTypeID": 5
        }
    ]
}
```

## Instructions to install
### if you use windows
#### Frist you need install the Visual Studio
* [Visual Studio 2017](https://visualstudio.microsoft.com/pt-br/downloads/)
---------------------------------------------------------------------------
#### Now you can install SQL Server
* [SQL Server 2017](https://www.microsoft.com/pt-pt/sql-server/sql-server-downloads)
---------------------------------------------------------------------------
#### Clone this project
	git clone git@github.com:VictorMessina/API-Pokemon.git
---------------------------------------------------------------------------
#### Run the application
 - API_Pokemon
---------------------------------------------------------------------------
#### Create the database with the schema
- 1 - Change the connection string in the file Web.config for your connection string and save the changes.
- 2 - Go to the Visual Studio package manager and write this: update-database.
- 3 - press enter and wait the migrations finish the job.
---------------------------------------------------------------------------
#### Start the server
- select the project and lauch the application
---------------------------------------------------------------------------
#### Finaly you can use any route with the right params.
- localhost:50594/pokemon/MythicalPokemonsByGeneration/second
---------------------------------------------------------------------------
### If you use linux or macOX
- 1 - install the Visual Studio
- 2 - Choose one database and install
- 3:
	- 3.1 - Change the connection string in the file Web.config for your connection string and save the changes.
	- 3.2 - Go to the Visual Studio package manager and write this: update-database.
	- 3.3 - press enter and wait the migrations finish the job.
- 4 - select the project and lauch the application
- 5 - Finaly you can use any route with the right params. Example: localhost:50594/pokemon/MythicalPokemonsByGeneration/second
