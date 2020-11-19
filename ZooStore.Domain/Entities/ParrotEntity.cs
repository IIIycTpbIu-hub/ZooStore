using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.Domain.Entities
{
    public enum ParrotSize
    {
        Small,
        Medium,
        Large
    }

    public class ParrotEntity : AnimalBase
    {
        public double Wingspan { get; set; }
        public bool Speaking { get; set; }
        public ParrotSize Size { get; set; }
    }
}
