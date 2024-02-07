using Contracts;
using Entitiess.Data;
using Entitiess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositry_Pattern
{
    public class ManufaturerRepo : IManufacturer
    {
        private readonly DataContext _dataContext;

        public ManufaturerRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Manufaturer> AddManufacturer(Manufaturer manufaturer)
        {
            var res = await _dataContext.Manufaturers.AddAsync(manufaturer);
            await _dataContext.SaveChangesAsync();
            return res.Entity;
        }

        public async Task DeleteManufacturer(int id)
        {
            var result = await _dataContext.Manufaturers.FirstOrDefaultAsync(mf => mf.Id == id);
            if (result != null)
            {
                _dataContext.Manufaturers.Remove(result);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Manufaturer>> GetManufacturer()
        {
            return await _dataContext.Manufaturers.ToListAsync();
        }

        public async Task<Manufaturer> GetManufacturerById(int id)
        {
            return await _dataContext.Manufaturers.FirstOrDefaultAsync(s => s.Id == id);

        }

        public async Task<Manufaturer> UpdateManufacturer(Manufaturer manufaturer)
        {
            var result = await _dataContext.Manufaturers.FirstOrDefaultAsync(s => s.Id == manufaturer.Id);
            if (result != null)
            {
                result.Manufacturer_Name = manufaturer.Manufacturer_Name;
                result.Manufacturer_Description = manufaturer.Manufacturer_Description;
                result.CreatedAt = manufaturer.CreatedAt;
                result.CreatedBy = manufaturer.CreatedBy;
                result.ModifiedAt = manufaturer.ModifiedAt;
                result.ModifiedBy = manufaturer.ModifiedBy;
                result.IsDeleted = manufaturer.IsDeleted;
                await _dataContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}