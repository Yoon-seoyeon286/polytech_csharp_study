using Newtonsoft.Json;

namespace _250912;

public class Pokemon
{
    [JsonProperty("name")]
    public string? Name { get; set; }
    
    [JsonProperty("sprites")]
    public OtherSprites? Sprites { get; set; }
}