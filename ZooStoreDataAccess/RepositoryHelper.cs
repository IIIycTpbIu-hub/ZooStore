using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.DataAccess
{
    public class RepositoryHelper
    {
        public RepositoryHelper(ZooStoreContext context)
        {
            context.Fish.Add(new Domain.Entities.FishEntity() { Id = 1, Name = "Fish1", Age = 1, Color = "Gold", HomeFish = true, Price = 100, Weight = 15 });
            context.Fish.Add(new Domain.Entities.FishEntity() { Id = 2, Name = "Fish2", Age = 110, Color = "Grey", HomeFish = true, Price = 25, Weight = 25 });
            context.SaveChanges();
        }
    }
}
