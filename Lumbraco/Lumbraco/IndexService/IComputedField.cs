﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.IndexService
{
    public interface IComputedIndexField
    {
        string ComputeFieldValue<T>(T item);
    }
}
