using System;
using System.Collections.Generic;
using System.Text;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;

namespace ZooStore.Story.Snake
{
    public class GetSnakeListStory : IStory<GetSnakeListStoryContext, IEnumerable<SnakeEntity>>
    {
        IRepository _repository;

        public GetSnakeListStory(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<SnakeEntity> Execute(GetSnakeListStoryContext context)
        {
            return _repository.GetAnimalByEnitiy<SnakeEntity>();
        }
    }
}
