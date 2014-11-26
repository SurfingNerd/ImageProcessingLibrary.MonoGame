using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLibrary.MonoGame
{
    public static class StaticMonoGameContext
    {
        private class DummyGame : Game
        {
            private GraphicsDeviceManager m_graphicsDeviceManager;

            public DummyGame()
            {
                m_graphicsDeviceManager = new GraphicsDeviceManager(this);
            }

            public void Init()
            {
                m_graphicsDeviceManager.CreateDevice();
                Initialize();
            }
        }


        //private static GraphicsDevice s_GraphicsDevice;
        private static DummyGame s_game;

        public static GraphicsDevice GraphicsDevice
        {
            get
            {
                EnsureGame();
                
                return s_game.GraphicsDevice;

                //if (s_GraphicsDevice == null)
                //{
                //    //we create a dummy game, the dummy game sets in the constructor internal used static variables
                //    Game dummyGame = new Game();
                    

                //    PresentationParameters parameters = new PresentationParameters()
                //            {
                //                BackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height,
                //                BackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width
                //            };
                //    parameters.DepthStencilFormat = DepthFormat.Depth24;

                //    s_GraphicsDevice =
                //        new Microsoft.Xna.Framework.Graphics.GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.HiDef,
                //            parameters);

                    
                    
                //}
                //return s_GraphicsDevice;
            }
        }

        private static void EnsureGame()
        {
            if (s_game == null)
            {
                s_game = new DummyGame();
                s_game.Init();
            }
        }
    }
}
