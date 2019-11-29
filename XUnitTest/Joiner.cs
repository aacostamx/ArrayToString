using System;
using System.Collections.Generic;

namespace XUnitTest
{
    public class Joiner
    {
        public string GetArrayToString<T>(IList<T> array, string separator = ", ") => String.Join(separator, array);
    }
}