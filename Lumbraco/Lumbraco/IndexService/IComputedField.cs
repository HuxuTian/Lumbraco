﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumbraco.Core.IndexService
{
    public interface IComputedIndexField<T>
    {
        string ComputeFieldValue(T item);
    }
}
