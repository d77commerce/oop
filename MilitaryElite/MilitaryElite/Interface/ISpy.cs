﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ISpy :ISoldier
    {
        public int CodeNumber { get; set; }
    }
}
