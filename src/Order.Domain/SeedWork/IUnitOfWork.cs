using System.Threading.Tasks;
namespace Order.Domain;
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
