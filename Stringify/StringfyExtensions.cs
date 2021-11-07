using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringify
{
    public static class StringfyExtensions
    {
        public static bool IsValidCultureName( this string cultureName)
        {
            if (cultureName == null)
                throw new ArgumentNullException(nameof(cultureName));

            return CultureInfo.GetCultures(CultureTypes.SpecificCultures).FirstOrDefault(culture => culture.Name == cultureName) != null;
        }
        public static string Currency(this decimal value, string culture)
        {
            if (culture.IsValidCultureName())
            {
                throw new ArgumentException("Invalid culture name!", culture);
            }

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(culture);
            return value.ToString("c", cultureInfo);
        }

    }
}
