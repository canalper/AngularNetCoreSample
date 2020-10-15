using AngularNetCoreSample.Data;
using AngularNetCoreSample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Service
{
    public class ApplicationStatusService : IApplicationStatusService
    {
        private readonly IApplicationStatusRepository ApplicationStatusRepository;
        public ApplicationStatusService(IApplicationStatusRepository applicationStatusRepository)
        {
            ApplicationStatusRepository = applicationStatusRepository;
        }

        public async Task<List<ApplicationStatus>> GetList()
        {
            return await Task.Run(() => ApplicationStatusRepository.GetList());
        }
    }
}
