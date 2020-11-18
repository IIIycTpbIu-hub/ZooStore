using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.Domain.Entities
{
    public abstract class AnimalBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
    }
}
