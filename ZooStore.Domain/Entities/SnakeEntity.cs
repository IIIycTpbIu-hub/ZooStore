using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.Domain.Entities
{
    public class SnakeEntity : AnimalBase
    {
        public bool Poisonous { get; set; }//ядовитый
        public double Lenght { get; set; }
    }
}
