using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

namespace TerrariaCN.LangCN
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        //public GraphicsDeviceManager graphics;
        // static Terraria.Main _game;

        public Game()
        {
            // Draw(null);
            //_game = this;
            //ScreenShot(this);
        }

        //GraphicsDeviceManager graphics;
        protected override void Update(GameTime gameTime)
        {
            ScreenShot();
            base.Update(gameTime);
        }

        public static void ScreenShot()
        {
            // _game = game;
            //if (Keyboard.GetState().IsKeyDown(Keys.F11))
            //{
            //    System.Windows.Forms.MessageBox.Show("测试");

            //    //GameWindow
            //    //ScreenShot("kkkkyue");
            //}
        }

        public static void ScreenShot(string prefix)
        {
            GraphicsDevice graphics = (GraphicsDevice)typeof(Terraria.Main).GetField("GraphicsDevice").GetValue(null);
            //typeof(Terraria.Main).get
            int w = graphics.PresentationParameters.BackBufferWidth;
            int h = graphics.PresentationParameters.BackBufferHeight;

            //强行调用一次Draw，用当前屏幕覆盖back buffer
            //Draw(new GameTime());

            //拷贝backbuffer
            int[] backBuffer = new int[w * h];
            graphics.GetBackBufferData(backBuffer);

            //拷贝至texture
            Texture2D texture = new Texture2D(graphics, w, h, false, graphics.PresentationParameters.BackBufferFormat);
            texture.SetData(backBuffer);

            //保存
            Stream stream = File.OpenWrite(prefix + "_" + Guid.NewGuid().ToString() + ".png");
            texture.SaveAsPng(stream, w, h);
            stream.Close();
        }
    }
}