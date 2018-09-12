using System.Globalization;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Rendering;

namespace MyBlazor.WebApp.Utils
{
    public class MBWebEnvironment : IMBEnvironment
    {
        public CultureInfo CurrentCulture
        {
            get
            {
                return CultureInfo.CurrentCulture;
            }
            set
            {
                CultureInfo.CurrentCulture = value;
                CultureInfo.CurrentUICulture = value;               
            }
        }
    }
}
