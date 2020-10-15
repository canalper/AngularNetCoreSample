using AngularNetCoreSample.Data;
using AngularNetCoreSample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Service
{
    public class CallTurningIntoApplicationService : ICallTurningIntoApplicationService
    {
        private readonly ICallTurningIntoApplicationRepository CallTurningIntoApplicationRepository;
        public CallTurningIntoApplicationService(ICallTurningIntoApplicationRepository callTurningIntoApplicationRepository)
        {
            CallTurningIntoApplicationRepository = callTurningIntoApplicationRepository;
        }

        public async Task<List<CallTurningIntoApplication>> GetList()
        {
            return await Task.Run(() => CallTurningIntoApplicationRepository.GetList());
        }
    }
}
