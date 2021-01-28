using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminClient
{
    public class DateTimeFormatter : IFormatProvider, ICustomFormatter
    {

        private CultureInfo enUsCulture = CultureInfo.GetCultureInfo("ko-KR");

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg is DateTime)
            {
                if (string.IsNullOrEmpty(format))
                {
                    // by default, format doubles to 3 decimal places
                    return string.Format(enUsCulture, "{0:9998-12-31}", arg);
                }
                else
                {
                    // if user supplied own format use it
                    return ((DateTime)arg).ToString("yyyy-MM-dd", enUsCulture);
                }
            }
            // format everything else normally
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, formatProvider);
            else
                return arg.ToString();
        }

        public object GetFormat(Type formatType)
        {
            return (formatType == typeof(ICustomFormatter)) ? this : null;
        }
    }
}
