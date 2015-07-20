using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCN.IL
{
    public class SpriteBatchCN:SpriteBatch
    {
        SpriteFontX sfx1;
        static SpriteBatchCN()
        {
           

        }
        public SpriteBatchCN(GraphicsDevice device):base(device)
        {
            GraphicsDeviceManager graphics = (GraphicsDeviceManager)typeof(Terraria.Main).GetField("graphics").GetValue(null);
            sfx1 = new SpriteFontX(new Font("黑体", 14f), graphics, TextRenderingHint.ClearTypeGridFit);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color)
        {
            //sfx.
             sfx1.Draw(this, str, position, color);
        }

        public void DrawString(SpriteFont sfx, char[] chars, Vector2 position, Microsoft.Xna.Framework.Color color)
        {
            sfx1.Draw(this, chars, position, color);
        }

        public void DrawString(SpriteFont sfx, string str, Vector2 position, Vector2 maxBound, Vector2 scale, Microsoft.Xna.Framework.Color color)
        {
            sfx1.Draw(this, str, position, maxBound, scale, color);
        }

        public void DrawString(SpriteFont sfx, char[] chars, Vector2 position, Vector2 maxBound, Vector2 scale, Microsoft.Xna.Framework.Color color)
        {
            sfx1.Draw(this, chars, position, maxBound, scale, color);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
        {
            sfx1.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), scale, color);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        {

           // sfx.
            sfx1.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), new Vector2(scale, scale), color);
        }
    }
}
