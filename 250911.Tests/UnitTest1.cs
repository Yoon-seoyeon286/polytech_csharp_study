using _250911.Data.DataSources;
using _250911.Data.Repositories;
using System.Linq;
using _250911.Models;

namespace _250911.Tests;

public class Tests
{
         [Test]
         public async Task Test1()
         {
             MockItemDataSource _mockItemDataSource = new MockItemDataSource();
             
             InventoryRepository _inventory = new InventoryRepository(_mockItemDataSource, 10,10);
           

             var checkItem = await _inventory.GetItemsAsync();
             Assert.IsTrue(checkItem.Any(items=> items.Name=="Sword"));
             Assert.IsTrue(checkItem.Any(items=> items.Name=="Shield"));
             
             
         }
}