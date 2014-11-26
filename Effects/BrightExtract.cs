using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame.Effects
{
    public class BrightExtractActivity : MonoGameShaderActivity
    {

        public float Threshold { get; set; }

        public BrightExtractActivity()
        {
            Threshold = 0.25f;
            
        }

        protected override Microsoft.Xna.Framework.Graphics.Effect GetEffect(ActivityContext context, Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice)
        {
            Effect effect = EffectLoader.LoadEffect(graphicsDevice, "BrightExtract.mgfxo");
            effect.Parameters["Threshold"].SetValue(Threshold);

            return effect;
        }

    }
}
