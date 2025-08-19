using CsharpStudy.Game.Characters;

namespace CsharpStudy.Game;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Cleric.MaxHp);
        
        Cleric.SetRandomMoney();
        
        Cleric cleric1 = new Cleric("person1");
        Cleric cleric2 = new Cleric("person2", 10);
        Cleric cleric3 = new Cleric("person3", 10, 10);
        
        List <Cleric> Clerics = new List<Cleric>();
        Clerics.Add(cleric1);
        Clerics.Add(cleric2);
        Clerics.Add(cleric3);

        Console.WriteLine(Clerics.Count);
        
        HashSet<Cleric> clericSet = new HashSet<Cleric>();
        clericSet.Add(cleric1);
        clericSet.Add(cleric2);
        clericSet.Add(cleric3);
        Console.WriteLine(clericSet.Count);
        
        HashSet<string> textSet = new HashSet<string>();
        textSet.Add("person");
        textSet.Add("person");
        Console.WriteLine(textSet.Count);

        Console.WriteLine(cleric1.GetHashCode());
        Console.WriteLine(cleric3.GetHashCode());

        string P1 = "Person";
        string P2 = "Person";
        Console.WriteLine(P1.GetHashCode());
        Console.WriteLine(P2.GetHashCode());
        
        Dictionary<Cleric, int> clericMap = new Dictionary<Cleric, int>();
        clericMap.TryAdd(cleric1, 100);
        clericMap.TryAdd(cleric2, 200);
        Console.WriteLine(clericMap.Count);

        List<string> menus = ["메뉴1", "메뉴2", "메뉴3"];
        menus.Sort();
        foreach (var menu in menus)
        {
            Console.WriteLine(menu);
        }
        
        menus.Sort((a, b) => a.CompareTo(b));
        
        Clerics.Sort();

        Character character = new Wizard();
        //Wizard wizard = (Wizard)character;

        if (character is Wizard wizard)
        {
            wizard.Fireball();
        }
        
        //Wizard wizard2 = (Wizard)character;
        Wizard? wizard2 = character as Wizard;

        string? nullableString = null;
        string nonNullableString = null; 
        

    }
}