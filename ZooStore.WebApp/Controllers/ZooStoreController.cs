﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZooStore.DataAccess;
using ZooStore.Domain.DTO;
using ZooStore.Domain.Entities;
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
        [Route("ZooStore")]
        [Route("ZooStore/GetFish")]
        public ActionResult<IEnumerable<AnimalBase>> GetFish()
        {
            var story = new GetFishListStory(_repository);
            var result = story.Execute(new GetFishListStoryContext()).ToList();
            return result;
        }
    }
}
