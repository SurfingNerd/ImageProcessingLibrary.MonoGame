using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageProcessingLibrary.MonoGame.Effects
{
    public abstract class MonoGameShaderActivity : IActivity, ISingleImageActivity, ICreateImageActivity
    {

        public string ImageName
        {
            get;set;
        }

        public string OutputImageName
        {
            get;
            set;
        }

        public void Execute(ActivityContext context)
        {
            GraphicsDevice gd = StaticMonoGameContext.GraphicsDevice;
            Texture2D tex2d = context.Get<Texture2D>(ImageName);

            //todo: Load Effect
            Effect effect = GetEffect(context, gd);

            RenderTarget2D renderTarget = new RenderTarget2D(gd,
                tex2d.Width,
                tex2d.Height,
                false,
                gd.PresentationParameters.BackBufferFormat,
                DepthFormat.Depth24);


            //Draw:

            gd.SetRenderTarget(renderTarget);
            gd.Clear(Color.Transparent);

            SpriteBatch spriteBatch = new SpriteBatch(gd);

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            //blurEffect.CurrentTechnique.Passes[0].Apply();
            foreach (EffectPass pass in effect.CurrentTechnique.Passes)
            {
                pass.Apply();
                //game.GraphicsDevice.DrawUserIndexedPrimitives(PrimitiveType.TriangleList, vertices, 0, 4, indices, 0, 2);
            }

            spriteBatch.Draw(tex2d, new Vector2(0, 0), Color.Transparent);
            spriteBatch.End();

            context.Set(OutputImageName, renderTarget);
        }

        protected abstract Effect GetEffect(ActivityContext context, GraphicsDevice graphicsDevice);
        
    }
}
