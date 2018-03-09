using System.Threading.Tasks;

namespace Vehicles.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}