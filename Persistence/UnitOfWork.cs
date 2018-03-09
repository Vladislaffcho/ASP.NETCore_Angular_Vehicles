using System.Threading.Tasks;
using Vehicles.Core;

namespace Vehicles.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VehiclesDbContext context;
        public UnitOfWork(VehiclesDbContext context)
        {
            this.context = context;

        }

        public Task CompleteAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}