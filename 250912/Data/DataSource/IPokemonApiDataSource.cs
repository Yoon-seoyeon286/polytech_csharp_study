using _250912;

namespace _250912.Data.DataSource;

public interface IPokemonApiDataSource<T>
{
    public Task<Response<List<T>>> GetPokemonAsync(string pokemonName);

}