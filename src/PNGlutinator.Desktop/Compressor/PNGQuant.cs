// GNU AFFERO GENERAL PUBLIC LICENSE version 3 Copyright (c) 2017 Javier Cañon | https://www.javiercanon.com 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace PNGlutinator.Compressor
{

    class PNGQuant : PNGCompressor
    {
        /// <summary>
        /// Compression options
        /// </summary>
        public CompressionTypeSettings.Indexed CompressionSettings = new PNGlutinator.CompressionTypeSettings.Indexed();

        /// <summary>
        /// Compress a PNG, creates a palleted png.
        /// </summary>
        /// <param name="fileToCompress">Data to compress</param>
        public PNGQuant (byte[] fileToCompress) : base (fileToCompress)
        {
            cmdLocation = AppDomain.CurrentDomain.BaseDirectory + @"\libs\pngquanti.exe";
        }

        /// <summary>
        /// Start compressing the png
        /// </summary>
        public override void Start()
        {
            Process cmdProcess = this.createProcess();
            string tmpFile = this.createTmpOriginalFile();
            string outputSuffix = "-fs8.png";
            
            if (CompressionSettings.OrderedDither)
            {
                cmdProcess.StartInfo.Arguments += " -ordered";
                outputSuffix = "-or8.png";
            }

            cmdProcess.StartInfo.Arguments += " " + CompressionSettings.Colours;
            cmdProcess.StartInfo.Arguments += " \"" + tmpFile.Replace("\"", @"\") + "\"";
            cmdProcess.Start();
            cmdProcess.WaitForExit();

            // build path for compressed file
            string compressedFilePath = tmpFile + outputSuffix;
            // pick up the compressed file
            compressedFile = File.ReadAllBytes(compressedFilePath);
            // tidy up
            File.Delete(compressedFilePath);
            deleteTmpOriginalFile();

            //Program.WriteToConsole(cmdProcess.StandardError.ReadToEnd());
            //Program.WriteToConsole(cmdProcess.StandardOutput.ReadToEnd());
        }
    }
}
