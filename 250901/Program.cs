namespace _250901;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string numString = "10.5";
            int num  = int.Parse(numString);
            Console.WriteLine(num); //예외 발생

        }
        catch (Exception e)
        {
            Console.WriteLine("0");
        }
    }
    
    
}