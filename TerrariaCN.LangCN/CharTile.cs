using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
