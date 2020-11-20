using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;
using ZooStore.Story.Animals;
using ZooStore.Story.Fish;
using ZooStore.Story.Parrot;
using ZooStore.Story.Snake;

namespace ZooStore.WebApp.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ZooStoreController : Controller
    {
        private readonly IRepository _repository;

        public ZooStoreController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<FishEntity> GetFish()
        {
            var story = new GetFishListStory(_repository);
            return story.Execute(new GetFishListStoryContext());
        }

        [HttpGet]
        public IEnumerable<AnimalBase> GetAnimals()
        {
            var story = new GetAnimalsStory(_repository);
            var result = story.Execute(new GetAnimalsStoryContext()).ToList();
            return result;
        }

        [HttpGet]
        public IEnumerable<ParrotEntity> GetParrots()
        {
            var story = new GetParrotsListStory(_repository);
            return story.Execute(new GetParrotsListStoryContext());
        }

        [HttpGet]
        public IEnumerable<SnakeEntity> GetSnakes()
        {
            var story = new GetSnakeListStory(_repository);
            return story.Execute(new GetSnakeListStoryContext());

        }
    }
}
