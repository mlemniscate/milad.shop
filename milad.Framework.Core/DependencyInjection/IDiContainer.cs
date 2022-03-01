﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace milad.Framework.Core.DependencyInjection
{
    public interface IDiContainer
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();
    }
}
