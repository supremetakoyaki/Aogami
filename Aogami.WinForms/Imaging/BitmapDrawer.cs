using System.Drawing.Drawing2D;

namespace Aogami.WinForms.Imaging
{
    internal static class BitmapDrawer
    {
        internal static Bitmap? DrawImage(Bitmap? source, int width, int height, bool highQuality = false, float deviceDpi = 96f)
        {
            if (source == null || (source.Width == width && source.Height == height))
            {
                return source;
            }

            float scaleFactor = deviceDpi / 96f;
            int scaleWidth = (int)(width * scaleFactor);
            int scaleHeight = (int)(height * scaleFactor);

            Bitmap output = new(scaleWidth, scaleHeight);
            using Graphics graphics = Graphics.FromImage(output);

            if (highQuality)
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }

            graphics.DrawImage(source, 0, 0, scaleWidth, scaleHeight);

            return output;
        }

        internal static void DrawResourceOnPictureBox(string resourceName, PictureBox control, bool highQuality = false)
        {
            if (Resources.ResourceManager.GetObject(resourceName) is not Bitmap resource)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new(() => control.Image = null));
                }
                else
                {
                    control.Image = null;
                }

                return;
            }

            float scaleFactor = control.DeviceDpi / 96f;
            int scaleWidth = (int)(control.Width * scaleFactor);
            int scaleHeight = (int)(control.Height * scaleFactor);

            if (control.InvokeRequired)
            {
                control.Invoke(new(() => control.Image = DrawImage(resource, scaleWidth, scaleHeight, highQuality, control.DeviceDpi)));
            }
            else
            {
                control.Image = DrawImage(resource, scaleWidth, scaleHeight, highQuality, control.DeviceDpi);
            }
        }
    }
}
