using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame
{
    public class Texture2DImageTypeConverter : SingleBitmapImageTypeConverter<Texture2D>
    {
        protected override System.Drawing.Bitmap ConverToBitmap(Texture2D instance)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                instance.SaveAsPng(memStream, instance.Width, instance.Height);
                memStream.Seek(0, SeekOrigin.Begin);

                return (System.Drawing.Bitmap)System.Drawing.Bitmap.FromStream(memStream);
            }
        }

        protected override Texture2D ConvertToSpecial(System.Drawing.Bitmap bitmap)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                bitmap.Save(memStream, System.Drawing.Imaging.ImageFormat.Png);
                memStream.Seek(0, SeekOrigin.Begin);
                Texture2D result = Texture2D.FromStream(StaticMonoGameContext.GraphicsDevice, memStream);
                return result;
            }
            //Texture2D result = new Texture2D(StaticMonoGameContext.GraphicsDevice, bitmap.Width, bitmap.Height);
        }
    }
}
