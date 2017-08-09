﻿// Copyright (c) 2017 Javier Cañon (www.javiercanon.com) (www.javiercañon.com)
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PNGlutinator
{
    public partial class ColourSettings : Form
    {
        public CompressionTypeSettings.Indexed CompressionSettings = new PNGlutinator.CompressionTypeSettings.Indexed();

        /// <summary>
        /// Create colour settings dialogue
        /// </summary>
        /// <param name="imgPath">Path to image to compress</param>
        public ColourSettings(string imgPath)
        {
            InitializeComponent();
            byte[] imageData = File.ReadAllBytes(imgPath);
            pngQuantPreview.OriginalImageData = imageData;
            pngQuantPreview.Draw();
        }

        private void ColourSettings_Load(object sender, EventArgs e)
        {
            pngQuantPreview.CompressionSettings.Colours = CompressionSettings.Colours;
            pngQuantPreview.CompressionSettings.OrderedDither = CompressionSettings.OrderedDither;

            // set up default values
            coloursComboBox.Text = pngQuantPreview.CompressionSettings.Colours.ToString();
            zoomComboBox.Text = "100%";
            ditherCheckbox.Checked = !pngQuantPreview.CompressionSettings.OrderedDither;
            previewTypeComboBox.SelectedIndex = 1;
            originalFileSizeLabel.Text = Math.Round(pngQuantPreview.OriginalImageData.Length / 1024.0, 2) + "k";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CompressionSettings = pngQuantPreview.CompressionSettings;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void zoomComboBox_TextUpdate(object sender, EventArgs e)
        {
            zoomComboBoxChanged();
        }

        private void zoomComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoomComboBoxChanged();
        }

        private void zoomComboBoxChanged()
        {
            string val = zoomComboBox.Text;
            // discard an optional % at the end of the value
            if (val.Substring(zoomComboBox.Text.Length - 1) == "%")
            {
                val = val.Substring(0, zoomComboBox.Text.Length - 1);
            }

            // silently fail if an invalid zoom level has been entered
            try
            {
                double zoom = Int16.Parse(val) / 100.0;
                if (zoom > 0)
                {
                    pngQuantPreview.Zoom = zoom;
                    pngQuantPreview.Draw();
                }
            }
            catch (Exception){}
            
            
        }

        private void coloursComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            coloursComboBoxChanged();
        }
        private void coloursComboBox_TextUpdate(object sender, EventArgs e)
        {
            coloursComboBoxChanged();
        }

        private void coloursComboBoxChanged()
        {
            try
            {
                int colours = Int16.Parse(coloursComboBox.Text);
                if (colours > 1 && colours < 257)
                {
                    pngQuantPreview.CompressionSettings.Colours = colours;
                    pngQuantPreview.Draw();
                }
            }
            catch (Exception) { }
        }

        private void ditherCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            pngQuantPreview.CompressionSettings.OrderedDither = !ditherCheckbox.Checked;
            pngQuantPreview.Draw();
        }

        private void previewTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (previewTypeComboBox.Text)
            {
                case "Compressed":
                    pngQuantPreview.PreviewType = PNGQuantPreviewControl.PreviewTypes.PNGQuant;
                    break;
                case "IE6 Display":
                    pngQuantPreview.PreviewType = PNGQuantPreviewControl.PreviewTypes.Ie6;
                    break;
                case "Original":
                    pngQuantPreview.PreviewType = PNGQuantPreviewControl.PreviewTypes.Original;
                    break;
            }
            pngQuantPreview.Draw();
        }

        private void pngQuantPreview_CompressedImageDataChange(object sender, EventArgs e)
        {
            compressedFileSizeLabel.Text = Math.Round(pngQuantPreview.CompressedImageData.Length / 1024.0, 2) + "k";
        }

        

        
    }
}
