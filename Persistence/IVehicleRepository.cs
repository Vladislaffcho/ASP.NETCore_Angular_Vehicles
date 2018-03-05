using System.Threading.Tasks;
using Vehicles.Models;

namespace Vehicles.Persistence
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated);
         void Add(Vehicle vehicle);
         void Remove(Vehicle vehicle);
    }
}