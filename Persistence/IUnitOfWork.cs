using System.Threading.Tasks;

namespace Vehicles.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}