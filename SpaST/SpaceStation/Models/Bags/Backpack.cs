﻿using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Bags
{
    class Backpack : IBag
    {
        public Backpack()
        {
            this.Items = new List<string>();
        }

        public ICollection<string>Items {get;}
    }
}
