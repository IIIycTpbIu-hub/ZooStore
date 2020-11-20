using System;
using System.Collections.Generic;
using System.Text;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;

namespace ZooStore.Story.Parrot
{
    public class GetParrotsListStory : IStory<GetParrotsListStoryContext, IEnumerable<ParrotEntity>>
    {
        IRepository _repository;

        public GetParrotsListStory(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ParrotEntity> Execute(GetParrotsListStoryContext context)
        {
            return _repository.GetAnimalByEnitiy<ParrotEntity>();
        }
    }
}
