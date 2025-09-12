using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace _250912;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class PokemonSPrites
{
    [JsonPropertyName("front_deault")]
    public string? OfficialArtworkUrl { get; set; }
}

public class OtherSprites
{
    [JsonPropertyName("official_artwork")]
    public PokemonSPrites? OfficialArtwork { get; set; }
}

public class Pokemon
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonProperty("sprites")]
    public OtherSprites? Sprites { get; set; }
}



    
