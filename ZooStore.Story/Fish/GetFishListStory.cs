using System;
using System.Threading.Tasks;
using ZooStore.Domain.Entities;
using ZooStore.DataAccess;
using System.Collections.Generic;

namespace ZooStore.Story.Fish
{
    class GetFishListStory : IStory<GetFishListStoryContext, List<FishEntity>>
    {
        IRepository _repository;
        public List<FishEntity> Execute(GetFishListStoryContext context) 
        {
            _repository.Get<FishEntity>();
        }

    }
}
