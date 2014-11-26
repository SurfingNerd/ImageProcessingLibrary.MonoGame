//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ImageProcessingLibrary.MonoGame
//{
//    public class BlurActivity : IActivity, ISingleImageActivity
//    {
//        public string ImageName
//        {
//            get;
//            set;
//        }

//        public void Execute(ActivityContext context)
//        {
//            VertexPositionNormalTexture[] vertices;
//            int[] indices;

//            CreateQuad(out vertices, out indices);
//            Texture2D tex2d = context.Get<Texture2D>(ImageName);

//            Matrix view = Matrix.CreateLookAt(new Vector3(0, 0, 2), Vector3.Zero, Vector3.Up);
//            Matrix projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.PiOver4, 4.0f / 3.0f, 1, 500);
//            BasicEffect basicEffect = new BasicEffect(StaticMonoGameContext.GraphicsDevice);

//            basicEffect.World = Matrix.Identity;
//            basicEffect.View = view;
//            basicEffect.Projection = projection;
//            basicEffect.TextureEnabled = true;
//            basicEffect.Texture = tex2d;

//            //todo: Load Effect
//            Effect blurEffect = null;

//            RenderTarget2D renderTarget = new RenderTarget2D(StaticMonoGameContext.GraphicsDevice,
//                tex2d.Width,
//                tex2d.Height,
//                false,
//                StaticMonoGameContext.GraphicsDevice.PresentationParameters.BackBufferFormat,
//                DepthFormat.Depth24);


//            //Draw:
//            StaticMonoGameContext.GraphicsDevice.SetRenderTarget(renderTarget);
//            StaticMonoGameContext.GraphicsDevice.Clear(Color.Transparent);
            
//            foreach (EffectPass pass in basicEffect.CurrentTechnique.Passes)
//            {
//                pass.Apply();
//                StaticMonoGameContext.GraphicsDevice.DrawUserIndexedPrimitives(PrimitiveType.TriangleList, vertices, 0, 4, indices, 0, 2);
//            }


//            StaticMonoGameContext.GraphicsDevice.SetRenderTarget(null);
//            StaticMonoGameContext.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.Transparent);


//            SpriteBatch spriteBatch = new SpriteBatch(StaticMonoGameContext.GraphicsDevice);
            
//            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
//            blurEffect.CurrentTechnique.Passes[0].Apply();
//            spriteBatch.Draw(renderTarget, new Vector2(0, 0), Color.White);
//            spriteBatch.End();

            


//            //GraphicsDeviceManager _graphics;
//            //SpriteBatch _spriteBatch;
//            //Matrix _view, _projection;
//            //Texture2D _tex2d;
//            //BasicEffect _basicEffect;
//            //Effect _blurEffect;

//            //RenderTarget2D _renderTarget;
//        }

//        private void CreateQuad(out VertexPositionNormalTexture[] vertices, out int[] indices)
//        {
//            vertices = new VertexPositionNormalTexture[4];
//            vertices[0].Position = new Vector3(-0.5f, -0.5f, 0f);
//            vertices[0].TextureCoordinate = new Vector2(0f, 1f);
//            vertices[0].Normal = Vector3.Backward;
//            vertices[1].Position = new Vector3(-0.5f, 0.5f, 0f);
//            vertices[1].TextureCoordinate = new Vector2(0f, 0f);
//            vertices[1].Normal = Vector3.Backward;
//            vertices[2].Position = new Vector3(0.5f, -0.5f, 0f);
//            vertices[2].TextureCoordinate = new Vector2(1f, 1f);
//            vertices[2].Normal = Vector3.Backward;
//            vertices[3].Position = new Vector3(0.5f, 0.5f, 0f);
//            vertices[3].TextureCoordinate = new Vector2(1f, 0f);
//            vertices[3].Normal = Vector3.Backward;

//            indices = new int[6];
//            indices[0] = 0;
//            indices[1] = 1;
//            indices[2] = 2;
//            indices[3] = 2;
//            indices[4] = 1;
//            indices[5] = 3;
//        }

        
//    }
//}
