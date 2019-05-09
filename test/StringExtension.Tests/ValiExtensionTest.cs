/**
 * ValidExtensionTest.cs
 *
 * Copyright (c) 2019 Kurihara.Jun
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */

using System;
using StringExtension;
using Xunit;

namespace StringExtension.Tests
{
    public class ValidExtensionTest
    {
        [Theory]
        [InlineData("a")]
        [InlineData("z")]
        [InlineData("A")]
        [InlineData("Z")]
        [InlineData("aa")]
        [InlineData("zz")]
        [InlineData("AA")]
        [InlineData("ZZ")]
        public void IsAlphabetSuccess(string source)
        {
            Assert.True(source.IsAlphabet(), $"source is {source}");
        }

        [Theory]
        [InlineData("")]
        [InlineData("1")]
        [InlineData("@")]
        [InlineData("!")]
        [InlineData(" ")]
        [InlineData("a1")]
        [InlineData("A1")]
        [InlineData("a ")]
        [InlineData(" a")]
        public void IsAlphabetFailed(string source)
        {
            Assert.False(source.IsAlphabet(), $"source is \"{source}\"");
        }

        [Fact]
        public void IsNumberSuccessZero()
        {
            var source = "0";
            Assert.True(source.IsNumber());
        }

        [Fact]
        public void IsNumberSuccessOne()
        {
            var source = "1";
            Assert.True(source.IsNumber());
        }

        [Fact]
        public void IsNumberSuccessMinus()
        {
            var source = "-1";
            Assert.True(source.IsNumber());
        }

        [Fact]
        public void IsNumverSuccessDecimal()
        {
            var source = "1.0";
            Assert.True(source.IsNumber());
        }

        [Fact]
        public void IsNumberSuccessDecimalMinus()
        {
            var source = "-1.0";
            Assert.True(source.IsNumber());
        }
    }
}
