using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame.Effects
{
    public static class EffectLoader
    {
        public static Effect LoadEffect(GraphicsDevice gd, string effectFile)
        {
            //TODO: Improve handling of effects. maybe embedd em in the assembly ?
            string effectsPath = @"C:\DEV\Vision\ImageProcessingLibrary.MonoGame\Effects\";
            return new Effect(gd, System.IO.File.ReadAllBytes(Path.Combine(effectsPath, effectFile)));
        }
    }
}
