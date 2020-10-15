using AngularNetCoreSample.Data;
using AngularNetCoreSample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Service
{
    public class TopClaimTopicService : ITopClaimTopicService
    {
        private readonly ITopClaimTopicRepository TopClaimTopicRepository;
        public TopClaimTopicService(ITopClaimTopicRepository topClaimTopicRepository)
        {
            TopClaimTopicRepository = topClaimTopicRepository;
        }

        public async Task<List<TopClaimTopic>> GetList()
        {
            return await Task.Run(() => TopClaimTopicRepository.GetList());
        }
    }
}
