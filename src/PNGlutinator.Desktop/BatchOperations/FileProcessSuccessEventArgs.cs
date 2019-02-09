// Copyright (c) 2017 Javier Cañon (www.javiercanon.com) (www.javiercañon.com)
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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGlutinator.BatchOperations
{
    public delegate void FileProcessSuccessEventHandler(object sender, FileProcessSuccessEventArgs e);

    /// <summary>
    /// Arguments for a successful file process
    /// </summary>
    public class FileProcessSuccessEventArgs : EventArgs
    {
        private string originalFilePath;
        /// <summary>
        /// Path to the original file
        /// </summary>
        public string OriginalFilePath
        {
            get
            {
                return originalFilePath;
            }
        }

        private string newFilePath;
        /// <summary>
        /// Path to the newly (over)written file
        /// </summary>
        public string NewFilePath
        {
            get
            {
                return newFilePath;
            }
        }


        private int filePathIndex;
        /// <summary>
        /// Index in the set of files given to the batch
        /// </summary>
        public int FilePathIndex
        {
            get
            {
                return filePathIndex;
            }
        }

        private Compressor.PNGCompressor compressor;
        /// <summary>
        /// Compressor that produced the smallest file. Null if compressor wasn't used (original file copied)
        /// </summary>
        public Compressor.PNGCompressor Compressor
        {
            get
            {
                return compressor;
            }
        }

        /// <summary>
        /// Arguments for a successful file process
        /// </summary>
        /// <param name="originalFilePath">Path to the original file</param>
        /// <param name="newFilePath">Path to the newly (over)written file</param>
        /// <param name="filePathIndex">Index in the set of files given to the batch</param>
        /// <param name="compressor">Compressor that produced the smallest file</param>
        public FileProcessSuccessEventArgs(string originalFilePath, string newFilePath, int filePathIndex, Compressor.PNGCompressor compressor)
            : base()
        {
            this.originalFilePath = originalFilePath;
            this.newFilePath = newFilePath;
            this.filePathIndex = filePathIndex;
            this.compressor = compressor;
        }

    }
}
