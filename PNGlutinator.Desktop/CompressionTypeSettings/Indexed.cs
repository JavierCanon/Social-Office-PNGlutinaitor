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

namespace PNGlutinator.CompressionTypeSettings
{
    public class Indexed
    {
        public event EventHandler PropertyChanged = delegate {};

        private int colours = 256;
        /// <summary>
        /// How many colours to give the image
        /// </summary>
        public int Colours
        {
            get
            {
                return colours;
            }
            set
            {
                if (value > 256 || value < 2)
                {
                    throw new ArgumentOutOfRangeException("Colours", value, "Invalid colour quantity - must be 2-256");
                }
                colours = value;
                OnPropertyChanged();
            }
        }

        private bool orderedDither = false;
        /// <summary>
        /// Use ordered dithering?
        /// </summary>
        public bool OrderedDither
        {
            get
            {
                return orderedDither;
            }
            set
            {
                orderedDither = value;
                OnPropertyChanged();
            }
        }

        public Indexed()
        {
        }

        /// <summary>
        /// Properties have changed
        /// </summary>
        private void OnPropertyChanged()
        {
            PropertyChanged(this, EventArgs.Empty);
        }
    }
}
