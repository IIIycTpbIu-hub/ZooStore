using System;
using System.Collections.Generic;
using System.Text;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;

namespace ZooStore.Story.Animals
{
    public class GetAnimalsStory : IStory<GetAnimalsStoryContext, IEnumerable<AnimalBase>>
    {
        IRepository _repository;

        public GetAnimalsStory(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<AnimalBase> Execute(GetAnimalsStoryContext context)
        {
            return _repository.GetAnimals();
        }
    }
}
