using AngularNetCoreSample.Data;
using AngularNetCoreSample.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Repository
{
    public class AnnualApplicationCountRepository : IAnnualApplicationCountRepository
    {
        public async Task<List<AnnualApplicationCount>> GetList()
        {
            using (var db = new AngularNetCoreSampleDbContext())
            {
                return await Task.Run(() => db.AnnualApplicationCount.AsNoTracking().OrderBy(m => m.Year).ToList());
            }          
        }

        public AnnualApplicationCount GetByID(int id)
        {
            using (var db = new AngularNetCoreSampleDbContext())
            {
                return db.AnnualApplicationCount.AsNoTracking().Where(m=>m.Id==id).OrderBy(m => m.Year).FirstOrDefault();
            }
        }
    }
}
