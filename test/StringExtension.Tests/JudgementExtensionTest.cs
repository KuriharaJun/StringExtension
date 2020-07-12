

using Xunit;
/**
* JudgementExtensionTest.cs
*
* Copyright (c) 2020 Kurihara.Jun
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
namespace StringExtension.Tests
{

    public class JudgementExtensionTest
    {

        [Theory]
        [InlineData("\r\n")]
        [InlineData("\r\nsample")]
        [InlineData("sample\r\n")]
        [InlineData("sam\r\nple")]
        [InlineData("\r\nsam\r\nple")]
        [InlineData("sam\r\nple\r\n")]
        public void TestIsWindowsStyleLineFeedReturnTrue(string source) => Assert.True(source.IsWindowsStyleLineFeed());

        [Theory]
        [InlineData("")]
        [InlineData("sample")]
        [InlineData("\n")]
        [InlineData("\r")]
        [InlineData("sample\n")]
        [InlineData("sample\r")]
        public void TestIsWindowsStyleLineFeedReturnFalse(string source) => Assert.False(source.IsWindowsStyleLineFeed());
    }
}
