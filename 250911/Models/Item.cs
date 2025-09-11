namespace _250911.Models;

public class Item
{
    private int _id {get; set;}
    private string _name {get; set;}
    private int _count {get; set;}

    public Item(int id, string name, int count)
    {
        _id = id;
        _name = name;
        _count = count;
    }
    

}