using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Stringify
{
    public class DecimalStringify
    {
    

        public string Currency(decimal value, string culture)
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
