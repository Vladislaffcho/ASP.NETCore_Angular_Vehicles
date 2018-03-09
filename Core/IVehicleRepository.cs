using System.Threading.Tasks;
using Vehicles.Models;

namespace Vehicles.Core
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = false);
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
    }
}