using _250912.Data.DataSource;
using Newtonsoft.Json;

namespace _250912.Data.RepositorySource;

public class PokemonRepository :IPokemonRepository
{
    private IPokemonApiDataSource<Post> _dataSource;

    public async Task<List<Post>> GetPostsAsync()
    {
      var response = await _dataSource.GetAllAsync();
      return JsonConvert.DeserializeObject<List<Post>>(response.Body)??new List<Post>();
      
    }

    public async Task<Pokemon?> GetPokemonByNameAsync(string pokemonName)
    {
        return _pokemonRepositoryImplementation.DeletePostAsync(pokemonName);
    }
    
}
