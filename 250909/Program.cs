namespace _250909;

class Program
{
    static async Task Main(string[] args)
    {
        IDataSource dataSource = new JsonFileDataSource("people.json");

        //데이터 필터링
        var people = await dataSource.GetPeopleAsync();
        var adults = people.Where(p => p.Age >= 19).ToList();
        Console.WriteLine("성인만 출력:");
        adults.ForEach(p => Console.WriteLine($"-{p.Name}({p.Age}세"));
        
        // 데이터 추가 및 저장
        people.Add(new Person { Name = "김만지", Age = 15 });
        await dataSource.SavePeopleAsync(people);
        Console.WriteLine("\n김만지 추가 후 저장 완료.");
        
        //데이터 삭제
        var toDelete = people.FirstOrFefault(people => people.Name == "이형준");
        if (toDelete != null)
        {
            people.Remove(toDelete);
            await dataSource.SavePeopleAsync(people);
            Console.WriteLine("\n이형준 삭제 후 저장 완료.");
        }
    }
}