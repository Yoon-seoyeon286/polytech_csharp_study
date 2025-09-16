using _250915.Data.Common;
using _250915.Data.DataSources;
using _250915.Data.Mapper;
using _250915.Data.Models;

namespace _250915.Data.Repositiories;

public class PokemonRepository : IPokemonRepsoitory
{
    private IPokemonApiDataSource<PokemonDto> _DataSource;

    public PokemonRepository(IPokemonApiDataSource<PokemonDto> dataSource)
    {
        _DataSource = dataSource;
    }

    public async Task<Result<PokemonDto?, PokemonError>> GetPokemonByNameAsync(string pokemonName)
    {
        try
        {
            var response = await _DataSource.GetPokemonAsync(pokemonName);

            switch (response.StatusCode)
            {
                case 200:
                    var dto = response.Body;
                    Pokemon pokemon = dto.ToModel();
                    return new Result<PokemonDto?, PokemonError>.Suceess(pokemon);
                    case 404:
                    return new Result<PokemonDto?, PokemonError>.Error(PokemonError.NotFound);
                    default:
                        return new Result<PokemonDto?, PokemonError>.Error(PokemonError.UnknownError);
                        

            }
        }
        catch (Exception ex)
        {
            return new Result<PokemonDto?, PokemonError>.Error(PokemonError.NetworkError);
        }
        

    }


}