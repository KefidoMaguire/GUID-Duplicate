﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUID_Duplicate
{
    static class GuidGenerator
    {
        //Generates a GUID
        public static Guid GuidGeneratorMethod()
        {
             Guid id = Guid.NewGuid();
             return id;
        }
    }
}
