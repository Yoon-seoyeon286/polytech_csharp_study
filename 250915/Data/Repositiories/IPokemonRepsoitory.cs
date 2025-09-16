using _250915.Data.Common;
using _250915.Data.Models;

namespace _250915.Data.Repositiories;

public interface IPokemonRepsoitory
{
    public Task<Result<PokemonDto?, PokemonError>> GetPokemonByNameAsync(string pokemonName);
}