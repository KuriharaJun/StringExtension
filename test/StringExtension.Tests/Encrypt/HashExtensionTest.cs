/**
 * HashExtensionTest.cs
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
using Xunit;

namespace StringExtension.Encrypt
{
    public class HashExtensionTest
    {
        [Fact]
        public void ThrownArgumentExceptionFromGenerateHashString()
        {
            var source = "";
            Assert.Throws<ArgumentException>(() => { source.GenerateHashString(HashAlgorithm.SHA256); });
        }

        [Fact]
        public void SHA1TestGenerateHashString()
        {
            var source = "SHA1";
            var actual = source.GenerateHashString(HashAlgorithm.SHA1);
            var expect = "e1744a525099d9a53c0460ef9cb7ab0e4c4fc939";
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void SHA256TestGenerateHashString()
        {
            var source = "SHA256";
            var actual = source.GenerateHashString(HashAlgorithm.SHA256);
            var expect = "b3abe5d8c69b38733ad57ea75e83bcae42bbbbac75e3a5445862ed2f8a2cd677";
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void SHA512TestGenerateHashString()
        {
            var source = "SHA512";
            var actual = source.GenerateHashString(HashAlgorithm.SHA512);
            var expect = "08af9a09ea069576ff02d11efe6822f9b09c105bcda44566e5b6b5c7a703dd778cbba35160190e79f3837c3275ba202231d19e764236c2bead580388e2fd0e7b";
            Assert.Equal(expect, actual);
        }
    }
}
