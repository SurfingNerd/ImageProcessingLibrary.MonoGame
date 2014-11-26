using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame.Effects
{
    public class DirectionalBlurActivity : MonoGameShaderActivity
    {
            /// <summary>
            /// Gets or sets the Input shader sampler.
            /// </summary>
            //[System.ComponentModel.BrowsableAttribute(false)]
            //public Brush Input
            //{
            //    get { return (Brush)GetValue(InputProperty); }
            //    set { SetValue(InputProperty, value); }
            //}

        public DirectionalBlurActivity()
        {
            BlurAmount = 1;
        }

            
        public float Angle { get; set; }

        public float BlurAmount { get; set; }

        protected override Microsoft.Xna.Framework.Graphics.Effect GetEffect(ActivityContext context, Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice)
        {
            Effect effect = EffectLoader.LoadEffect(graphicsDevice, "DirectionalBlur.mgfxo");
            effect.Parameters["Angle"].SetValue(Angle);
            effect.Parameters["BlurAmount"].SetValue(BlurAmount);
            return effect;

        }
 

        
    }
}
