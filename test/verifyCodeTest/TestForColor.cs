using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using CoreVerify;

namespace verifyCodeTest
{
    public class TestForColor
    {
        [Fact]
        public void ColorTest()
        {
            var color = new RGB("#f0c");
            var color2 = color + new RGB(1, 1, 1);
        }
    }
}
