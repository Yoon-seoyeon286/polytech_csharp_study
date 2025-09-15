namespace _250915.Data.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Pokemon(int id, string name)
    {
        Id = id;
        Name = name;
    }

    protected bool Equals(Pokemon other)
    {
        return Id == other.Id && Name == other.Name;
    }

    public override bool Equals(object? obj)
    {
        if(obj is null) return false;
        if(ReferenceEquals(this, obj)) return true;
        if(obj.GetType() != GetType()) return false;
        return Equals((Pokemon)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
    }
}