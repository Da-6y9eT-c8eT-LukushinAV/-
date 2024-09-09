using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    internal class CustomConverter
    {
        public static bool Convert(string value, out int result)
        {
            return int.TryParse(value, out result);
        }

        public static bool Convert(string value, out double result)
        {
            return double.TryParse(value, out result);
        }

        public static bool Convert(string value, out bool result)
        {
            return bool.TryParse(value, out result);
        }

        public static bool Convert(string value, out DateTime result)
        {
            return DateTime.TryParse(value, out result);
        }

        public static bool Convert(string value, out long result)
        {
            return long.TryParse(value, out result);
        }
    }
}
