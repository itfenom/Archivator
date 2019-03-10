﻿using GZipTest.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZipTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var compressor = new MultitreadFileCompressor(4);
            compressor.CompressFile(@"C:\Users\Ilfat\source\repos\GZipTest\sample.txt", @"C:\Users\Ilfat\source\repos\GZipTest\sample.mzip");
        }
    }
}