﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QI4N.Framework
{
    public interface IdentityGenerator
    {
        string generate( Type compositeType );
    }
}
