using _250912.Data.RepositorySource;

namespace _250912_Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        IPokemonRepository pokemonRepository = new PokemonRepository();    
        
        Assert.Pass();
    }
}