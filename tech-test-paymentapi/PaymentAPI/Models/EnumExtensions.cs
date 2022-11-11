using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum @enum)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])@enum
               .GetType()
               .GetField(@enum.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
