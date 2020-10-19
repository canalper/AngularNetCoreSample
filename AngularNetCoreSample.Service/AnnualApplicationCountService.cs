using AngularNetCoreSample.Data;
using AngularNetCoreSample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Service
{
    public class AnnualApplicationCountService : IAnnualApplicationCountService
    {
        private readonly IAnnualApplicationCountRepository AnnualApplicationCountRepository;
        public AnnualApplicationCountService(IAnnualApplicationCountRepository annualApplicationCountRepository)
        {
            AnnualApplicationCountRepository = annualApplicationCountRepository;
        }

        public async Task<List<AnnualApplicationCount>> GetList()
        {
            return await Task.Run(() => AnnualApplicationCountRepository.GetList());
        }

        public AnnualApplicationCount GetByID(int id)
        {
            return AnnualApplicationCountRepository.GetByID(id);
        }
    }
}
