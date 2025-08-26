namespace CsharpStudy_0826;

public class Data
{
    public static List<Transaction> transactions = new List<Transaction>
    {
        new Transaction(new Trader("Brian", "Cambridge"), 2011, 300),
        new Transaction(new Trader("Raoul", "Cambridge"), 2012, 1000),
        new Transaction(new Trader("Raoul", "Cambridge"), 2011, 400),
        new Transaction(new Trader("Mario", "Milan"), 2012, 710),
        new Transaction(new Trader("Mario", "Milan"), 2012, 700),
        new Transaction(new Trader("Alan", "Cambridge"), 2012, 950)
    };

    public static void Main(string[] args)
    {
        // 1. 2011년에 일어난 모든 트랜잭션을 찾아 가격 기준 오름차순으로 정리하여 이름을 나열하시오: where
        transactions.Where(transactions => transactions.Year ==2011)
            .OrderBy(transactions=>transactions.Value)
            .Select(transactions=>transactions.Trader.Name)
            .ToList()
            .ForEach(Console.WriteLine);
        Console.WriteLine("=======================");
        
        // 2. 거래자가 근무하는 모든 도시를 중복 없이 나열하시오 /Select
        transactions.Select(transactions => transactions.Trader.City)
            .ToHashSet()
            .ToList()
            .ForEach(Console.WriteLine);
        Console.WriteLine("=======================");
        
        // 3. 케임브리지에서 근무하는 모든 거래자를 찾아서 이름순으로 정렬하여 나열하시오/Where /Select
        transactions.Where(transactions=>transactions.Trader.City =="Cambridge")
            .OrderBy(transactions=> transactions.Trader.Name)
            .Select(transactions=>transactions.Trader.Name)
            .ToList()
            .ForEach(Console.WriteLine);
        Console.WriteLine("=======================");
        
        // 4. 모든 거래자의 이름을 알파벳순으로 정렬하여 나열하시오/Select
        transactions.OrderBy(transactions=>transactions.Trader.Name)
            .Select(transactions=>transactions.Trader.Name)
            .ToList()
            .ForEach(Console.WriteLine);
        Console.WriteLine("=======================");
        
        // 5. 밀라노에 거래자가 있는가?Any
        bool result = transactions.Any(transactions=>transactions.Trader.City =="Milan");
            Console.WriteLine(result);
            Console.WriteLine("=======================");
        
       // 6. 케임브리지에 거주하는 거래자의 모든 트랙잭션값을 출력하시오/Where /Select
       transactions.Where(transactions=>transactions.Trader.City =="Cambridge")
           .Select(transactions=>transactions.Value)
           .ToList()
           .ForEach(Console.WriteLine);
       Console.WriteLine("=======================");
       
       // 7. 전체 트랜잭션 중 최대값은 얼마인가?/Aggregate
       int maxResult = transactions.Max(transactions=>transactions.Value);
       Console.WriteLine(maxResult);
       Console.WriteLine("=======================");
       
       // 7. 전체 트랜잭션 중 최대값은 얼마인가?/Aggregate2
       int maxResult2 = transactions.Select(transactions => transactions.Value)
           .Aggregate((e, v) => Math.Max(e,v));
       Console.WriteLine(maxResult2);
       Console.WriteLine("=======================");
       
       // 8. 전체 트랜잭션 중 최소값은 얼마인가?/Aggregate
       int minResult = transactions.Min(transactions=>transactions.Value);
       Console.WriteLine(minResult);
       Console.WriteLine("=======================");
       
       // 8. 전체 트랜잭션 중 최소값은 얼마인가?/Aggregate2
       int minResul2 = transactions.Select(transactions=>transactions.Value)
           .Aggregate((e, v) => Math.Min(e,v));
       Console.WriteLine(minResul2);

    }

    
}