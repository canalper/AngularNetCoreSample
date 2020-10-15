using AngularNetCoreSample.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularNetCoreSample.Repository.Interfaces
{
    public interface ITopClaimTopicService
    {
        Task<List<TopClaimTopic>> GetList();
    }
}
