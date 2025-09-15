using _250915.Data.Models;

namespace _250915.Data.Repositiories;

public interface IPokemonRepsoitory
{
    public Task<Pokemon?> GetPokemonByNameAsync(string pokemonName);
}