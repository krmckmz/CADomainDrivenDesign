namespace Order.Infrastructure;
namespace Order.Application;
using System;
using System.Threading.Tasks;

public class BuyerRepository : IBuyerRepository
{
    public Task<int> SaveChangesAsync()
    {
      return Task.FromResult(1);
    }
}
