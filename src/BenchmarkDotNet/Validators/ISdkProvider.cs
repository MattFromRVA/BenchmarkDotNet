﻿using System.Collections.Generic;

namespace BenchmarkDotNet.Validators
{
    public interface ISdkProvider
    {
        IEnumerable<string> GetInstalledSdks();
    }
}