﻿using System.Collections.Generic;
using System.Linq;

namespace FuncSharp
{
    public static class Structural
    {
        /// <summary>
        /// Calculates structural hashcode of the specified values.
        /// </summary>
        public static int HashCode(IEnumerable<object?> values)
        {
            unchecked
            {
                var result = 19;
                foreach (var value in values)
                {
                    result += 41 * (value?.GetHashCode() ?? 0);
                }
                return result;
            }
        }

        /// <summary>
        /// Calculates structural hashcode of the specified values.
        /// </summary>
        public static int HashCode(params object?[] values)
        {
            return HashCode(values.AsEnumerable());
        }
    }
}
