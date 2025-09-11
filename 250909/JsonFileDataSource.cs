namespace _250909;

public class JsonFileDataSource : IDataSource
{
    private readonly List<Person>_people = new List<Person>();

    public async Task<List<Person>> GetPeopleAsync()
    {
        await Task.Delay(500);
        return _people;
    }

    public async Task SavePeopleAsync(List<Person> people)
    {
        await Task.Delay(500);
        _people.AddRange(people);
    }

    public JsonFileDataSource(string fileName)
    {
        
    }


}