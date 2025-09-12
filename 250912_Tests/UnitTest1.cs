using _250912;
using _250912.Data.DataSource;
using _250912.Data.RepositorySource;

namespace _250912_Tests;

public class Tests
{
    [Test]
    public async Task Test1()
    {
        IPokemonRepository pokemonRepository = new PokemonRepository(new PokemonDataSource(new HttpClient()));

        Pokemon pokemon = await pokemonRepository.GetPokemonByNameAsync("Roselia");
        Assert.NotNull(pokemon);
    }
}