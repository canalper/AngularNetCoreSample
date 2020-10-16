using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularNetCoreSample.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularNetCoreSample.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private IAnnualApplicationCountService AnnualApplicationCountService;
        private ITopClaimTopicService TopClaimTopicService;
        private ICallTurningIntoApplicationService CallTurningIntoApplicationService;
        private IApplicationStatusService ApplicationStatusService;
        public DashboardController(IAnnualApplicationCountService annualApplicationCountService,
            ITopClaimTopicService topClaimTopicService,
            ICallTurningIntoApplicationService callTurningIntoApplicationService,
            IApplicationStatusService applicationStatusService)
        {
            AnnualApplicationCountService = annualApplicationCountService;
            TopClaimTopicService = topClaimTopicService;
            CallTurningIntoApplicationService = callTurningIntoApplicationService;
            ApplicationStatusService = applicationStatusService;
        }
         
        [HttpGet]
        public async Task<IActionResult> GetAnnualApplicationCount()
        {
            var AnnualApplicationCounts = await Task.Run(() => AnnualApplicationCountService.GetList());
            return Ok(AnnualApplicationCounts);
        }

        [HttpGet]
        public async Task<IActionResult> GetTopClaimTopic()
        {
            var TopClaimTopicServices = await Task.Run(() => TopClaimTopicService.GetList());
            return Ok(TopClaimTopicServices);
        }

        [HttpGet]
        public async Task<IActionResult> GetApplicationStatus()
        {
            var ApplicationStatusServices = await Task.Run(() => ApplicationStatusService.GetList());
            return Ok(ApplicationStatusServices);
        }

        [HttpGet]
        public async Task<IActionResult> GetCallTurningIntoApplication()
        {
            var CallTurningIntoApplicationServices = await Task.Run(() => CallTurningIntoApplicationService.GetList());
            return Ok(CallTurningIntoApplicationServices);
        }
    }
}
