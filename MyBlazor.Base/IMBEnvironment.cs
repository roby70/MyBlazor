using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyBlazor
{
    public interface IMBEnvironment
    {
        CultureInfo CurrentCulture { get; set; }
    }
}
