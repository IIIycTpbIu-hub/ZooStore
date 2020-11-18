using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZooStore.Domain.Entities;

namespace ZooStore.Story.Fish
{
    class GetFishListStory : IStory<GetFishListStoryContext, FishEntity>
    {
        public FishEntity Execute(GetFishListStoryContext context)
        {
            throw new NotImplementedException();
        }

        public Task<FishEntity> ExecuteAsync(GetFishListStoryContext context)
        {
            throw new NotImplementedException();
        }
    }
}
