﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ISoldier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
