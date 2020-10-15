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
    public class CallTurningIntoApplicationRepository : ICallTurningIntoApplicationRepository
    {
        public async Task<List<CallTurningIntoApplication>> GetList()
        {
            using (var db = new AngularNetCoreSampleDbContext())
            {
                return await Task.Run(() => db.CallTurningIntoApplication.AsNoTracking().OrderBy(m => m.Year).ToList());
            }          
        }
    }
}
