using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace FoodExpress.Common
{
    public static class ImageHelper
    {
        public static string GetImagesDirectory()
        {
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            return dir;
        }

        // Safely load image into memory without locking file on disk
        public static Image? LoadImageSafe(string? relativeOrFullPath)
        {
            if (string.IsNullOrWhiteSpace(relativeOrFullPath))
                return null;

            string fullPath = relativeOrFullPath;
            if (!Path.IsPathRooted(fullPath))
            {
                fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeOrFullPath);
            }

            if (!File.Exists(fullPath))
                return null;

            try
            {
                byte[] bytes = File.ReadAllBytes(fullPath);
                using var ms = new MemoryStream(bytes);
                return new Bitmap(ms);
            }
            catch
            {
                return null;
            }
        }

        // Generates an appetizing placeholder badge/card for a food item and saves it
        public static string GeneratePlaceholderImage(string itemName, string categoryName, Color primaryColor, string emojiOrIcon)
        {
            try
            {
                string imagesDir = GetImagesDirectory();
                string safeName = string.Join("_", itemName.Split(Path.GetInvalidFileNameChars()));
                string filePath = Path.Combine(imagesDir, $"{safeName}.png");

                if (File.Exists(filePath))
                    return Path.Combine("Images", $"{safeName}.png");

                int width = 240;
                int height = 180;

                using var bmp = new Bitmap(width, height);
                using (var g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                    // Gradient background
                    using var brush = new LinearGradientBrush(
                        new Point(0, 0),
                        new Point(width, height),
                        primaryColor,
                        Color.FromArgb(
                            Math.Max(0, primaryColor.R - 40),
                            Math.Max(0, primaryColor.G - 40),
                            Math.Max(0, primaryColor.B - 40)
                        )
                    );
                    g.FillRectangle(brush, 0, 0, width, height);

                    // Decorative circle in background
                    using var circleBrush = new SolidBrush(Color.FromArgb(30, 255, 255, 255));
                    g.FillEllipse(circleBrush, width - 80, -30, 140, 140);
                    g.FillEllipse(circleBrush, -20, height - 80, 120, 120);

                    // Category tag badge
                    using var badgeBrush = new SolidBrush(Color.FromArgb(180, 0, 0, 0));
                    g.FillRectangle(badgeBrush, 10, 10, 130, 24);
                    using var badgeFont = new Font("Segoe UI", 8f, FontStyle.Bold);
                    g.DrawString(categoryName.ToUpper(), badgeFont, Brushes.WhiteSmoke, 15, 14);

                    // Icon/Emoji or abbreviation
                    using var iconFont = new Font("Segoe UI", 32f, FontStyle.Bold);
                    var iconSize = g.MeasureString(emojiOrIcon, iconFont);
                    g.DrawString(emojiOrIcon, iconFont, Brushes.White, (width - iconSize.Width) / 2, 45);

                    // Item Name
                    using var titleFont = new Font("Segoe UI", 10.5f, FontStyle.Bold);
                    var titleRect = new RectangleF(10, 120, width - 20, 50);
                    using var sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center,
                        Trimming = StringTrimming.EllipsisWord
                    };
                    g.DrawString(itemName, titleFont, Brushes.White, titleRect, sf);
                }

                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                return Path.Combine("Images", $"{safeName}.png");
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
