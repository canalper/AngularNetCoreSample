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
    public class TopClaimTopicRepository : ITopClaimTopicRepository
    {
        public async Task<List<TopClaimTopic>> GetList()
        {
            using (var db = new AngularNetCoreSampleDbContext())
            {
                return await Task.Run(() => db.TopClaimTopic.AsNoTracking().OrderBy(m => m.TopicDescription).ToList());
            }          
        }
    }
}
