﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZooStore.Domain.Entities
{
    public class FishEntity : AnimalBase
    {
        public string Color { get; set; }
        public bool HomeFish { get; set; }
    }
}
