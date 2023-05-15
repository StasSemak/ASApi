﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Helpers
{
    public static class ImageWorker
    {
        private static string folderPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).FullName,
            "BussinesLogic", "Images");

        public static Bitmap FromBase64StringToImage(this string base64String)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            try
            {
                MemoryStream memoryStream = new MemoryStream(byteBuffer);
                memoryStream.Position = 0;
                Image image = Image.FromStream(memoryStream);
                memoryStream.Close();
                byteBuffer = null;
                return new Bitmap(image);
            }
            catch { return null; }
        }

        public static string SaveImage(string imageBase64)
        {
            string filename = Path.GetRandomFileName() + ".jpg";
            try
            {
                if (imageBase64.Contains(",")) imageBase64 = imageBase64.Split(',')[1];
                var image = imageBase64.FromBase64StringToImage();
                CompressImage(image, 1200, 1200, false)
                    .Save(Path.Combine(folderPath, filename), ImageFormat.Jpeg);
            }
            catch(Exception ex)
            {
                throw new Exception("Error saving image!\n" + ex.ToString());
            }
            return filename;
        }

        public static Bitmap CompressImage(Bitmap originalPic, int maxWidth, int maxHeight, bool watermark = true, bool transperent = false)
        {
            try
            {
                int width = originalPic.Width;
                int height = originalPic.Height;
                int widthDiff = width - maxWidth;
                int heightDiff = height - maxHeight;
                bool doWidthResize = (maxWidth > 0 && width > maxWidth && widthDiff > heightDiff);
                bool doHeightResize = (maxHeight > 0 && height > maxHeight && heightDiff > widthDiff);

                if (doWidthResize || doHeightResize || (width.Equals(height) && widthDiff.Equals(heightDiff)))
                {
                    int iStart;
                    Decimal divider;
                    if (doWidthResize)
                    {
                        iStart = width;
                        divider = Math.Abs((Decimal)iStart / maxWidth);
                        width = maxWidth;
                        height = (int)Math.Round((height / divider));
                    }
                    else
                    {
                        iStart = height;
                        divider = Math.Abs((Decimal)iStart / maxHeight);
                        height = maxHeight;
                        width = (int)Math.Round(width / divider);
                    }
                }
                using (Bitmap outBmp = new Bitmap(width, height, PixelFormat.Format24bppRgb))
                {
                    using (Graphics oGraphics = Graphics.FromImage(outBmp))
                    {
                        //oGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        //oGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        oGraphics.Clear(Color.White);
                        oGraphics.DrawImage(originalPic, 0, 0, width, height);
                        //Watermark
                        if (watermark)
                        {

                            using (Image watermarkImage = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "Images", "watermark.png")))
                            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                            {
                                //Not responsive
                                //int x = (outBmp.Width - watermarkImage.Width - 15);
                                //int y = (outBmp.Height - watermarkImage.Height -15);
                                double imageHeightBrand = Convert.ToDouble(watermarkImage.Height);
                                double imageWidthBrand = Convert.ToDouble(watermarkImage.Width);
                                double ratioBrand = imageWidthBrand / imageHeightBrand;

                                double imageHeightBild = Convert.ToDouble(outBmp.Height); //height of the image to watermark
                                double imageWidthBild = Convert.ToDouble(outBmp.Width);
                                var imageWidthTmpBranding = imageWidthBild * 0.2; //the watermark width, but only 20% size of the image to watermark
                                var imageHeightTmpBranding = imageWidthTmpBranding / ratioBrand; //height of watermark, preserve aspect ratio
                                int imageWidthBranding = Convert.ToInt32(imageWidthTmpBranding); //convert in into int32 (see method below)
                                int imageHeightBranding = Convert.ToInt32(imageHeightTmpBranding);

                                int watermarkX = (int)(imageWidthBild - imageWidthBranding); // Bottom Right
                                int watermarkY = (int)(imageHeightBild - imageHeightBranding);
                                oGraphics.DrawImage(watermarkImage,
                                    new Rectangle(watermarkX, watermarkY, imageWidthBranding, imageHeightBranding),
                                    new Rectangle(0, 0, (int)imageWidthBrand, (int)imageHeightBrand),
                                    GraphicsUnit.Pixel);
                                //watermarkBrush.TranslateTransform(watermarkX, watermarkY);
                                //oGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(watermarkX, watermarkY), new Size(watermarkImage.Width, watermarkImage.Height)));
                            }
                        }
                        if (transperent)
                        {
                            outBmp.MakeTransparent();
                        }

                        return new Bitmap(outBmp);
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    
        public static void RemoveImage(string filename)
        {
            try
            {
                string file = Path.Combine(folderPath, filename);
                if(File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            catch
            {
                throw new Exception("Error removing file!");
            }
        }
    }
}
