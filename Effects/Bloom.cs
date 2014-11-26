using ImageProcessingLibrary.MonoGame.Effects;
using Microsoft.Xna.Framework.Graphics;
namespace ShaderEffectLibrary
{
    /// <summary>
    /// This is the implementation of an extensible framework ShaderEffect which loads
    /// a shader model 2 pixel shader. Dependecy properties declared in this class are mapped
    /// to registers as defined in the *.ps file being loaded below.
    /// </summary>
    public class BloomEffectActivity : MonoGameShaderActivity
    {
        public BloomEffectActivity()
        {
            BloomIntensity = 1;
            BaseIntensity = 1;
            BloomSaturation = 1;
            BaseSaturation = 1;
        }



        public float BloomIntensity
        {
            get; set;
        }


        public float BaseIntensity
        {
            get;
            set;
        }

        public float BloomSaturation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the BaseSaturation variable within the shader.
        /// </summary>
        public float BaseSaturation
        {
            get;
            set;
        }

        protected override Microsoft.Xna.Framework.Graphics.Effect GetEffect(ImageProcessingLibrary.ActivityContext context, GraphicsDevice gd)
        {
            Effect effect = EffectLoader.LoadEffect(gd,"Bloom.mgfxo");
            effect.Parameters["BloomIntensity"].SetValue(BloomIntensity);
            effect.Parameters["BaseIntensity"].SetValue(BaseIntensity);
            effect.Parameters["BloomSaturation"].SetValue(BloomSaturation);
            effect.Parameters["BaseSaturation"].SetValue(BaseSaturation);
            effect.Parameters["implicitInputSampler"].SetValue(context.Get<Texture2D>(this.ImageName));
            return effect;

        }
    }
}
