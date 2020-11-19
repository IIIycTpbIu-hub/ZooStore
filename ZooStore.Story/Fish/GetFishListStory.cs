using ZooStore.Domain.Entities;
using ZooStore.DataAccess;
using System.Collections.Generic;
using ZooStore.Domain.DTO;

namespace ZooStore.Story.Fish
{
    public class GetFishListStory : IStory<GetFishListStoryContext, IEnumerable<AnimalBase>>
    {
        IRepository _repository;

        public GetFishListStory(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<AnimalBase> Execute(GetFishListStoryContext context) 
        {
            return _repository.GetAnimalByEnitiy<FishEntity>();
        }
    }
}
