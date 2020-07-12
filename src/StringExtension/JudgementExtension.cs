/**
 * StringExtension.cs
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

namespace StringExtension
{
    public static class JudgementExtension
    {
        private static readonly string _WindowsLineFeed = "\r\n";

        /// <summary>
        /// Judgement string include Unix style linefeed control.
        /// </summary>
        /// <param name="source">Target string</param>
        /// <returns>If linefeed control is LF only then return true.</returns>
        public static bool IsUnixStyleLineFeed(this string source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Judgement string include Windows style linefeed control.
        /// </summary>
        /// <param name="source">Target string</param>
        /// <returns>If linefeed control is CRLF then return true.</returns>
        public static bool IsWindowsStyleLineFeed(this string source) => source.IndexOf(_WindowsLineFeed) >= 0;

        /// <summary>
        /// Judgement string include Mac style linefeed control.
        /// </summary>
        /// <param name="source">Target string</param>
        /// <returns>If linefeed control is CR only then return true.</returns>
        public static bool IsMacStyleLineFeed(this string source)
        {
            throw new NotImplementedException();
        }
    }
}
