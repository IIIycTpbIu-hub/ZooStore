﻿using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;
using ZooStore.Story;
using ZooStore.Story.Fish;

namespace ZooStore.WebApp
{
    public static class IocContainer
    {
        public static void Config(this IServiceCollection services)
        {
            services.AddMvc();
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IStory<GetFishListStoryContext, IEnumerable<AnimalBase>>, GetFishListStory>();
        }
    }
}
