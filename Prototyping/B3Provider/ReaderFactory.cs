﻿#region License
/*
 * ReaderFactory.cs
 *
 * The MIT License
 *
 * Copyright (c) 2018 Felipe Bahiana Almeida
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 * 
 * Contributors:
 * - Felipe Bahiana Almeida <felipe.almeida@gmail.com> https://www.linkedin.com/in/felipe-almeida-ba222577
 */
#endregion

namespace B3Provider
{
    using B3Provider.Readers;
    using System;

    public static class ReaderFactory
    {
        public static IReader<T> CreateReader<T>()
        {
            if (typeof(T) == typeof(B3EquityInfo))
            {
                return (IReader<T>)new B3EquityInfoReader();
            }
            
            if (typeof(T) == typeof(B3OptionOnEquityInfo))
            {
                return (IReader<T>)new B3OptionOnEquityInfoReader();
            }

            throw new InvalidOperationException();
        }

        public static IReader<T> CreateReader<T>(ReadStrategy strategy)
        {
            var reader = CreateReader<T>();
            reader.ReadStrategy = strategy;

            return reader;
        }
    }
}
