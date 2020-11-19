using Microsoft.AspNetCore.Mvc;
using ZooStore.DataAccess;
using ZooStore.Domain.DTO;
using ZooStore.Story.Fish;

namespace ZooStore.WebApp.Controllers
{
    [ApiController]
    public class ZooStoreController : Controller
    {
        private readonly IRepository _repository;

        public ZooStoreController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<FishDto> GetFish()
        {
            var story = new GetFishListStory(_repository);
            return story.Execute(new GetFishListStoryContext());
        }
    }
}
