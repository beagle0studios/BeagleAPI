﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public interface IBeagleCompare
    { 
        bool Compare<T>(T objectToCompare);
        bool CompareSelf<T>(T objectToCompare, IBeagleCompare objectSelf);
    }
}
