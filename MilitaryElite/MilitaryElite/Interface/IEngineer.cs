﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface IEngineer :ISpecialisedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}
