using _250911.Data.DataSources;
using _250911.Data.Repositories;
using _250911.Models;

namespace _250911;

public class MockItemDataSource:IItemDataSource
{
    private List<Item> _items=[];
    public async Task<List<Item>> LoadAllItemsAsync()
    {
        return _items;
    }

    public async Task SaveAllItemsAsync(List<Item> items)
    {
        _items = items;
    }
    
}