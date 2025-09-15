namespace _250915.Data.Mapper;

public static class PokemonMappers
{
    public static Models.Pokemon ToModel(this PokemonDto dto)
    {
        return new Models.Pokemon
        (
            id: dto.Id,
            name: dto.Name
        );
    }
    
}