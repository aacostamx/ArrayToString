# How to convert a generic array into a string

Here we have a good way to convert a generic array into a string.

<strong>Joiner Class</strong>
<pre><code>
using System;
using System.Collections.Generic;

namespace XUnitTest
{
    public class Joiner
    {
        public string GetArrayToString&lt;T&gt;(IList&lt;T&gt; array, string separator = ", ") =&gt; String.Join(separator, array);
    }
}
</code></pre>
<strong>Unit Test</strong>
<pre><code>
using Xunit;

namespace XUnitTest
{
    public class ArrayToString
    {
        [Fact]
        public void Join()
        {
            var join = new Joiner();
            string result = join.GetArrayToString(new int[] { 1, 2, 3, 4, 5 });
            Assert.Equal("1, 2, 3, 4, 5", result);
        }

        [Fact]
        public void Join_Separator()
        {
            var join = new Joiner();
            string result = join.GetArrayToString(new int[] { 1, 2, 3, 4, 5 }, "|");
            Assert.Equal("1|2|3|4|5", result);
        }

        [Fact]
        public void Join_Separator_Generic()
        {
            var join = new Joiner();
            string result = join.GetArrayToString(new decimal[] { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m });
            Assert.Equal("1.1, 2.2, 3.3, 4.4, 5.5", result);
        }
    }
}
</code></pre>
