﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Domain
{
    public class Admin:User
    {

        public int AccessLevel { get; set; }
    }
}
