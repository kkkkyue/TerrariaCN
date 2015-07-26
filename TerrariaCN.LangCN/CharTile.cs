using Microsoft.Xna.Framework.Graphics;

namespace Microsoft.Xna.Framework
{
    public class CharTile
    {
        public readonly Microsoft.Xna.Framework.Rectangle Rectangle;
        public readonly Texture2D Texture;

        public CharTile(Texture2D texture, Microsoft.Xna.Framework.Rectangle rectangle)
        {
            this.Texture = texture;
            this.Rectangle = rectangle;
        }
    }
}