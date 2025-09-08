namespace _250908;

class Program
{
    public static async Task<string> FirstBird()
    {
        await Task.Delay(1000);
        return "꾸우우";
    }

    public static async Task<string> SecondBird()
    {
        await Task.Delay(2000);
        return "까악";
    }

    public static async Task<string> ThirdBird()
    {
        await Task.Delay(3000);
        return "짹쨱쨲ㄱ잭";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}