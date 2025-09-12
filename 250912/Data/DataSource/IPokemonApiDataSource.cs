using _250912;

namespace _250912.Data.DataSource;

public interface IPokemonApiDataSource
{
    public Task<Response> GetPokemonAsync(string pokemonName);

}