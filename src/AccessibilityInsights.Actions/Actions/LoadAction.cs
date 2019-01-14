// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using AccessibilityInsights.Actions.Attributes;
using AccessibilityInsights.Actions.Enums;
using AccessibilityInsights.Core.Bases;
using AccessibilityInsights.Desktop.Settings;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;

namespace AccessibilityInsights.Actions
{
    /// <summary>
    /// Action to load snapshot file
    /// </summary>
    [InteractionLevel(UxInteractionLevel.NoUxInteraction)]
    public static class LoadAction
    {
        /// <summary>
        /// Extract snapshot file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        internal static LoadActionParts LoadSnapshotZip(string path)
        {
            using (FileStream str = File.Open(path, FileMode.Open))
            using (Package package = ZipPackage.Open(str, FileMode.Open))
            {
                var parts = package.GetParts();

                var elementPart = (from p in parts where p.Uri.OriginalString == "/" + SaveAction.elementFileName select p.GetStream()).First();
                A11yElement element = A11yElement.FromStream(elementPart);
                elementPart.Close();

                Bitmap bmp;
                try
                {
                    var bmpPart = (from p in parts where p.Uri.OriginalString == "/" + SaveAction.screenshotFileName select p.GetStream()).First();
                    bmp = LoadBmp(bmpPart);
                    bmpPart.Close();
                }
                catch (InvalidOperationException)  // Gets thrown if screenshot doesn't exist in file
                {
                    bmp = null;
                }

                var metadataPart = (from p in parts where p.Uri.OriginalString == "/" + SaveAction.metatdataFileName select p.GetStream()).First();
                SnapshotMetaInfo meta = SnapshotMetaInfo.DeserializeFromStream(metadataPart);
                metadataPart.Close();   

                var selectedElement = element.FindDescendent(k => k.UniqueId == meta.ScreenshotElementId);

                return new LoadActionParts(element, bmp, selectedElement.SynthesizeBitmapFromElements(), meta);
            }
        }

        /// <summary>
        /// Load bmp from stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static Bitmap LoadBmp(Stream stream)
        {
            Image img = Image.FromStream(stream);
            return new Bitmap(img);
        }

        /// <summary>
        /// Load JSON stored metadata file from stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private static SnapshotMetaInfo LoadMetadata(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                string jsonMeta = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<SnapshotMetaInfo>(jsonMeta);
            }
        }
    }
}
