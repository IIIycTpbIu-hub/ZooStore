using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.DataAccess
{
    public class RepositoryHelper
    {
        public RepositoryHelper(ZooStoreContext context)
        {
            context.Fish.Add(new Domain.Entities.FishEntity() { Name = "Fish1", Age = 1, Color = "Gold", HomeFish = true, Price = 100, Weight = 15 });
            context.SaveChanges();
        }
    }
}
