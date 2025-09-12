using _250912.Data.DataSource;

namespace _250912.Data.RepositorySource;

public class PokemonRepository :IPokemonRepository
{
    private IPokemonApiDataSource _datasource;
    
    public async Task<Pokemon?> GetPokemonByNameAsync(string pokemonName)
    {
     
        return await 
    }
    
}
