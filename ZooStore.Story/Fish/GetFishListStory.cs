using System;
using System.Threading.Tasks;
using ZooStore.Domain.Entities;
using ZooStore.DataAccess;
using System.Collections.Generic;

namespace ZooStore.Story.Fish
{
    class GetFishListStory : IStory<GetFishListStoryContext, List<FishEntity>>
    {
        IRepository<FishEntity> _repository;
        public List<FishEntity> Execute(GetFishListStoryContext context) => ExecuteAsync(context).GetAwaiter().GetResult();

        public Task<List<FishEntity>> ExecuteAsync(GetFishListStoryContext context)
        {
            _repository.Get<FishEntity>()
        }
    }
}
