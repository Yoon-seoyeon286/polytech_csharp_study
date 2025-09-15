using _250915.Data.Mapper;

namespace _250915_Tests;

public class Tests
{
    [Test]
    public void MapperTest1()
    {
        var PokemonDto = new PokemonDto()
        {
            Id = 315,
            Name = "Roselia",
        };

        var PokemonModel = PokemonDto.ToModel();
        
        Assert.NotNull(PokemonModel);
        Assert.That(PokemonModel.Name, Is.EqualTo("Roselia"));


    }
}