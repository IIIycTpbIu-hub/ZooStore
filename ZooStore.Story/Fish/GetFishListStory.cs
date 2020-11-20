using ZooStore.Domain.Entities;
using ZooStore.DataAccess;
using System.Collections.Generic;
using ZooStore.Domain.DTO;

namespace ZooStore.Story.Fish
{
    public class GetFishListStory : IStory<GetFishListStoryContext, IEnumerable<FishEntity>>
    {
        IRepository _repository;

        public GetFishListStory(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<FishEntity> Execute(GetFishListStoryContext context) 
        {
            var result = _repository.GetAnimalByEnitiy<FishEntity>();
            return result;
        }
    }
}
