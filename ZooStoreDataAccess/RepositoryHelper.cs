using System;
using System.Collections.Generic;
using System.Text;
using ZooStore.Domain.Entities;

namespace ZooStore.DataAccess
{
    public class RepositoryHelper
    {
        public RepositoryHelper(ZooStoreContext context)
        {
            context.Animals.Add(new FishEntity() { Id = 1, Name = "Fish1", Age = 1, Color = "Gold", HomeFish = true, Price = 100, Weight = 15 });
            context.Animals.Add(new FishEntity() { Id = 2, Name = "Fish2", Age = 110, Color = "Grey", HomeFish = true, Price = 25, Weight = 25 });
            context.Animals.Add(new ParrotEntity() { Id = 3, Name = "Kesha", Age = 2, Price = 200, Size = ParrotSize.Medium, Speaking = true, Wingspan = 50 });
            context.Animals.Add(new ParrotEntity() { Id = 4, Name = "Kirill", Age = 5, Price = 150, Size = ParrotSize.Small, Speaking = false, Wingspan = 15 });
            context.Animals.Add(new SnakeEntity() { Id = 5, Name = "Test", Age = 1, Lenght = 100, Poisonous = false, Price = 500, Weight = 100 });
            context.SaveChanges();
        }
    }
}
