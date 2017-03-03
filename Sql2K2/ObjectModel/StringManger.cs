using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql2K2.ObjectModel
{
    /// <summary>
    /// Manage string functionalities
    /// </summary>
    public static class StringManger
    {

        /// <summary>
        /// Retruns true if string is not empty
        /// </summary>
        public static bool NotEmpty(this string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// Retruns true if string is empty
        /// </summary>
        public static bool IsEmpty(this string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

    }
}
