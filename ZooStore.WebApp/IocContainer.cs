using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;
using ZooStore.Story;
using ZooStore.Story.Animals;
using ZooStore.Story.Fish;

namespace ZooStore.WebApp
{
    public static class IocContainer
    {
        public static void Config(IServiceCollection services)
        {
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IStory<GetFishListStoryContext, IEnumerable<AnimalBase>>, GetFishListStory>();
            services.AddTransient<IStory<GetAnimalsStoryContext, IEnumerable<AnimalBase>>, GetAnimalsStory>();
        }
    }
}
