using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using ZooStore.DataAccess;
using ZooStore.Domain.Entities;
using ZooStore.Story;
using ZooStore.Story.Animals;
using ZooStore.Story.Fish;
using ZooStore.Story.Parrot;
using ZooStore.Story.Snake;

namespace ZooStore.WebApp
{
    public static class IocContainer
    {
        public static void Config(IServiceCollection services)
        {
            services.AddSingleton<IRepository, Repository>();
            services.AddTransient<IStory<GetFishListStoryContext, IEnumerable<FishEntity>>, GetFishListStory>();
            services.AddTransient<IStory<GetAnimalsStoryContext, IEnumerable<AnimalBase>>, GetAnimalsStory>();
            services.AddTransient<IStory<GetParrotsListStoryContext, IEnumerable<ParrotEntity>>, GetParrotsListStory>();
            services.AddTransient<IStory<GetSnakeListStoryContext, IEnumerable<SnakeEntity>>, GetSnakeListStory>();
        }
    }
}
