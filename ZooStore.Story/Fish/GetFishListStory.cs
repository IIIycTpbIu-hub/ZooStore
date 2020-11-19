using System;
using System.Threading.Tasks;
using ZooStore.Domain.Entities;
using ZooStore.DataAccess;
using System.Collections.Generic;
using ZooStore.Domain.DTO;

namespace ZooStore.Story.Fish
{
    public class GetFishListStory : IStory<GetFishListStoryContext, FishDto>
    {
        IRepository _repository;

        public GetFishListStory(IRepository repository)
        {
            _repository = repository;
        }
        public FishDto Execute(GetFishListStoryContext context) 
        {
            var fish = _repository.Get<FishEntity>(new FishEntity());
            return new FishDto() { FishList = fish as List<FishEntity>};
        }
    }
}
