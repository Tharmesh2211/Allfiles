using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IManufacturer
    {
        Task<IEnumerable<Manufaturer>> GetManufacturer();
        Task<Manufaturer> GetManufacturerById(int id);
        Task<Manufaturer> AddManufacturer(Manufaturer manufaturer);
        Task<Manufaturer> UpdateManufacturer(Manufaturer manufaturer);
        Task DeleteManufacturer(int id);
    }
}
