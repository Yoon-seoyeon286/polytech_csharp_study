using _250911.Models;

namespace _250911.Data.DataSources;

public interface IItemDataSource
{
    Task<List<Item>>LoadAllItemsAsync();
    Task SaveAllItemsAsync(List<Item> items);
    
}