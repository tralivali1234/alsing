﻿namespace QI4N.Framework.Bootstrap
{
    using System;

    public interface ApplicationAssembly
    {
        LayerAssembly NewLayerAssembly();
    }

    public class ApplicationAssemblyImpl : ApplicationAssembly
    {
        public LayerAssembly NewLayerAssembly()
        {
            throw new NotImplementedException();
        }
    }
}