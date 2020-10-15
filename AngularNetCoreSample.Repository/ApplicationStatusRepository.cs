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
    public class ApplicationStatusRepository : IApplicationStatusRepository
    {
        public async Task<List<ApplicationStatus>> GetList()
        {
            using (var db = new AngularNetCoreSampleDbContext())
            {
                return await Task.Run(() => db.ApplicationStatus.AsNoTracking().OrderBy(m => m.Description).ToList());
            }          
        }
    }
}
