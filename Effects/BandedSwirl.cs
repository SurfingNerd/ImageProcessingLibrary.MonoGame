using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame.Effects
{
    public class BandedSwirlActivity : MonoGameShaderActivity
    {
        /// <summary>
        /// Creates the and updates the registered values defined within the pixel shader using the default values.
        /// </summary>
        public BandedSwirlActivity()
        {
            CenterX = 0.5f;
            CenterY = 0.5f;
            SwirlStrength = 0.5f;
            DistanceThreshold = 0.2f;
        }

        
        public float CenterX { get; set; }
        public float CenterY { get; set; }
        public float SwirlStrength { get; set; }
        public float DistanceThreshold { get; set; }

        protected override Microsoft.Xna.Framework.Graphics.Effect GetEffect(ActivityContext context, Microsoft.Xna.Framework.Graphics.GraphicsDevice graphicsDevice)
        {
            Microsoft.Xna.Framework.Graphics.Effect  result = 
                EffectLoader.LoadEffect(graphicsDevice, "BandedSwirl.mgfxo");
            result.Parameters["center"].SetValue(new Microsoft.Xna.Framework.Vector2(CenterX, CenterY));
            result.Parameters["spiralStrength"].SetValue(SwirlStrength);
            result.Parameters["distanceThreshold"].SetValue(DistanceThreshold);

            return result;
        }
       
    }
}
