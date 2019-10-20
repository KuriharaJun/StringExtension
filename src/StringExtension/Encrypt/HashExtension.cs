/**
 * HashExtension.cs
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
using System.Text;
using System.Security.Cryptography;

namespace StringExtension.Encrypt
{

    /// <summary>
    /// This class is converted hashed value from source string.
    /// </summary>
    public static class HashExtension
    {
        /// <summary>
        /// Generate hashed string of the string to according to hash algorithm.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="hashAlgorithm"></param>
        /// <returns></returns>
        public static string GenerateHashString(this string source,
                                                HashAlgorithm hashAlgorithm = HashAlgorithm.SHA256)
        {
            if (string.IsNullOrEmpty(source)) throw new ArgumentException(nameof(source));

            var sourceData = Encoding.UTF8.GetBytes(source);

            byte[] hashedData = null;
            switch (hashAlgorithm)
            {
                case HashAlgorithm.SHA1:
                    using (var hash = SHA1.Create())
                    {
                        hashedData = hash.ComputeHash(sourceData);
                    }
                    break;
                case HashAlgorithm.SHA512:
                    {
                        using (var hash = SHA512.Create())
                        {
                            hashedData = hash.ComputeHash(sourceData);
                        }
                        break;
                    }
                case HashAlgorithm.SHA256:
                default:
                    {
                        using (var hash = SHA256.Create())
                        {
                            hashedData = hash.ComputeHash(sourceData);
                        }
                        break;
                    }
            }
            var result = BitConverter.ToString(hashedData).ToLower().Replace("-", "");
            return result;
        }
    }
}
