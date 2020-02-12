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
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PNGlutinator.BatchOperations
{
    public delegate void FileProcessFailEventHandler(object sender, FileProcessFailEventArgs e);

    /// <summary>
    /// Arguments for a failed file process
    /// </summary>
    public class FileProcessFailEventArgs : EventArgs
    {
        private string filePath;
        /// <summary>
        /// Path to the original file
        /// </summary>
        public string FilePath
        {
            get
            {
                return filePath;
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

        private string error;
        /// <summary>
        /// Reason for the file to fail processing
        /// </summary>
        public string Error
        {
            get
            {
                return error;
            }
        }

        

        /// <summary>
        /// Arguments for a failed file process
        /// </summary>
        /// <param name="filePath">Path to the original file</param>
        /// <param name="filePathIndex">Index in the set of files given to the batch</param>
        /// <param name="error">Error that caused the fail</param>
        public FileProcessFailEventArgs(string filePath, int filePathIndex, Exception error)
            : base()
        {
            this.filePath = filePath;
            this.filePathIndex = filePathIndex;
            this.error = error.Message;
        }

    }
}
