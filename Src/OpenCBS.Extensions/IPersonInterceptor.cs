﻿using System.Collections.Generic;

namespace OpenCBS.Extensions
{
    public interface IPersonInterceptor
    {
        void Save(IDictionary<string, object> interceptorParams);
        void Update(IDictionary<string, object> interceptorParams);
    }
}
