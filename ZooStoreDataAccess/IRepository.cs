using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ZooStore.Domain.Entities;

namespace ZooStore.DataAccess
{
    public interface IRepository
    {
        IEnumerable<AnimalBase> GetFish();
        IEnumerable<AnimalBase> GetAnimals();
    }
}
