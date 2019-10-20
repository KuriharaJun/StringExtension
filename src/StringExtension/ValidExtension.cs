/**
 * ValidExtension.cs
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
using System.Linq;
using System.Text.RegularExpressions;

namespace StringExtension
{
    /// <summary>
    /// This extension class is validating to string  value.
    /// </summary>
    public static class ValidExtension
    {
        /// <summary>
        /// Pattern of float with sign
        /// </summary>
        /// <returns></returns>
        private const string _FloatPatternWithSign = "(^[-+]?)[\\d]+([\\.]?[\\d]+)*?$";

        /// <summary>
        /// Pattern of float without sign
        /// </summary>
        /// <returns></returns>
        private const string _FloatPatternWithoutSign = "^[\\d]+([\\.]?[\\d]+)*?$";

        /// <summary>
        /// Pattern of integer with sign
        /// </summary>
        /// <returns></returns>
        private const string _IntegerPatternWithSign = "(^[-+]?)[\\d]+$";

        /// <summary>
        /// Returns the result of alphabetic validation of string value.
        /// This validation range is 'A' to 'Z' and 'a' to 'z'.
        /// This range is not match ASCII chars.Use IsASCII when validate ASCII chars.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Result of alphabet validation</returns>
        public static bool IsAlphabetOnly(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return false;

            return source.ToCharArray().All(c => (c >= 0x41 && 0x5a >= c)
                                            || (c >= 0x61 && 0x7a >= c));
        }

        /// <summary>
        /// Returns the result of number validation of string value.
        /// This validation is including plus or minus sign.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Result of number validation</returns>
        public static bool IsFloatWithSign(this string source)
        {
            return new Regex(_FloatPatternWithSign).IsMatch(source);
        }

        /// <summary>
        /// Returns the result of number validation of string value.
        /// This validation is excluding plus or minus sign.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Result of number validation</returns>
        public static bool IsFloatWithoutSign(this string source)
        {
            return new Regex(_FloatPatternWithoutSign).IsMatch(source);
        }

        /// <summary>
        /// Returns the result of integer validation.
        /// This validation is including plus or minus sign.
        /// </summary>
        /// <param name="source">validating value</param>
        /// <returns>Result of number validation</returns>
        public static bool IsIntegerWithSign(this string source)
        {
            return new Regex(_IntegerPatternWithSign).IsMatch(source);
        }

        /// <summary>
        /// Returns the result of integer validation.
        /// This validation is excluding plus or minus sign.
        /// </summary>
        /// <param name="source">validating value</param>
        /// <returns>Result of number validation</returns>
        public static bool IsIntegerWithoutSign(this string source)
        {
            if (source == string.Empty) return false;
            return source.All(c => c >= 0x30 && 0x39 >= c);
        }

        /// <summary>
        /// Returns the result of ASCII chars validation of value.
        /// This validation is including Control characters.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool IsASCII(this string source)
        {
            if (string.IsNullOrEmpty(source)) return false;
            return source.All(c => c >= 0x00 && 0x7E >= c);
        }

        /// <summary>
        /// Returns the result which validate all characters are upper case alphabet.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool IsOnlyUpperCaseAlphabet(this string source)
        {
            if (source == string.Empty) return false;
            return source.ToCharArray().All(c => (c >= 0x41 && 0x5a >= c));
        }

        /// <summary>
        /// Returns the result which validate all characters are lower case alphabet.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool IsOnlyLowerCaseAlphabet(this string source)
        {
            if (source == string.Empty) return false;
            return source.ToCharArray().All(c => (c >= 0x61 && 0x7a >= c));
        }

        /// <summary>
        /// Returns the result which validate characters include lower case alphabet.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool HasLowerCaseAlphabet(this string source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the result which validate characters include upper case alphabet.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool HasUpperCaseAlphabet(this string source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the result which validate characters include alphabet.
        /// </summary>
        /// <param name="source">Validating value</param>
        /// <returns>Validation result</returns>
        public static bool HasAlphabet(this string source)
        {
            throw new NotImplementedException();
        }
    }
}
