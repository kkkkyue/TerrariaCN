namespace Microsoft.Xna.Framework
{
    using Microsoft.Xna.Framework.Graphics;
    //using Microsoft.Xna.Framework.Graphics;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    //using System.Drawing.Imaging;
    using System.Drawing.Text;
    using System.IO;

    public class SpriteFontX
    {
        protected Bitmap bitmap;
        private static Brush brush;
        public Dictionary<char, CharTile> CharTiles;
        protected int CurrentLeft;
        protected int CurrentMaxHeight;
        protected Texture2D CurrentTex2d;
        protected int CurrentTop;
        private System.Drawing.Font font;
        protected IGraphicsDeviceService GDS;
        protected System.Drawing.Graphics gr;
        private object lockObj;
        protected SizeF sizef;
        public Vector2 Spacing;
        private static MemoryStream strm;
        private static Bitmap tempBp;
        private static System.Drawing.Graphics tempGr;
        protected List<Texture2D> Tex2ds;
        private System.Drawing.Text.TextRenderingHint textRenderingHint;

        public SpriteFontX(System.Drawing.Font font, IGraphicsDeviceService gds, System.Drawing.Text.TextRenderingHint trh)
        {
            this.lockObj = new object();
            this.Initialize(font, gds, trh);
        }

        public SpriteFontX(string fontName, float size, IGraphicsDeviceService gds, System.Drawing.Text.TextRenderingHint trh)
        {
            this.lockObj = new object();
            this.Initialize(new System.Drawing.Font(fontName, size, FontStyle.Bold), gds, trh);
        }

        protected unsafe void AddTex(char chr)
        {
            lock (this.lockObj)
            {
                if (!this.CharTiles.ContainsKey(chr))
                {
                    string text = chr.ToString();
                    this.sizef = tempGr.MeasureString(text, this.Font, PointF.Empty, StringFormat.GenericTypographic);
                    if (this.sizef.Width <= 0f)
                    {
                        this.sizef.Width = this.sizef.Height / 2f;
                    }
                    if (((this.bitmap == null) || (((int)Math.Ceiling((double)this.sizef.Width)) != this.bitmap.Width)) || (((int)Math.Ceiling((double)this.sizef.Height)) != this.bitmap.Height))
                    {
                        this.bitmap = new Bitmap((int)Math.Ceiling((double)this.sizef.Width), (int)Math.Ceiling((double)this.sizef.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        this.gr = System.Drawing.Graphics.FromImage(this.bitmap);
                    }
                    else
                    {
                        this.gr.Clear(System.Drawing.Color.Empty);
                    }
                    this.gr.TextRenderingHint = this.textRenderingHint;
                    this.gr.DrawString(text, this.Font, brush, 0f, 0f, StringFormat.GenericTypographic);
                    if (this.bitmap.Height > this.CurrentMaxHeight)
                    {
                        this.CurrentMaxHeight = this.bitmap.Height;
                    }
                    if (((this.CurrentLeft + this.bitmap.Width) + 1) > this.CurrentTex2d.Width)
                    {
                        this.CurrentTop += this.CurrentMaxHeight + 1;
                        this.CurrentLeft = 0;
                    }
                    if ((this.CurrentTop + this.CurrentMaxHeight) > this.CurrentTex2d.Height)
                    {
                        this.newTex();
                    }
                    CharTile tile = new CharTile(this.CurrentTex2d, new Rectangle(this.CurrentLeft, this.CurrentTop, this.bitmap.Width, this.bitmap.Height));
                    this.CharTiles.Add(chr, tile);
                    int[] numArray = new int[this.bitmap.Width * this.bitmap.Height];
                    System.Drawing.Imaging.BitmapData bitmapdata = this.bitmap.LockBits(new System.Drawing.Rectangle(0, 0, this.bitmap.Width, this.bitmap.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    int* numPtr = (int*)bitmapdata.Scan0;
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        if (numPtr[0] != 0)
                        {
                            numArray[i] = numPtr[0];
                        }
                        numPtr++;
                    }
                    this.bitmap.UnlockBits(bitmapdata);
                    this.GDS.GraphicsDevice.Textures[0] = null;
                    this.CurrentTex2d.SetData<int>(0, new Rectangle?(tile.Rectangle), numArray, 0, numArray.Length);
                    this.CurrentLeft += tile.Rectangle.Width + 1;
                }
            }
        }

        public void AddText(string str)
        {
            this.AddText(str.ToCharArray());
        }

        public void AddText(char[] chrs)
        {
            for (int i = 0; i < chrs.Length; i++)
            {
                this.AddTex(chrs[i]);
            }
        }

        public Vector2 Draw(SpriteBatch sb, string str, Vector2 position, Color color)
        {
            return this.Draw(sb, str.ToCharArray(), position, new Vector2(float.MaxValue, float.MaxValue), Vector2.One, color);
        }

        public Vector2 Draw(SpriteBatch sb, char[] chars, Vector2 position, Color color)
        {
            return this.Draw(sb, chars, position, new Vector2(float.MaxValue, float.MaxValue), Vector2.One, color);
        }

        public Vector2 Draw(SpriteBatch sb, string str, Vector2 position, Vector2 maxBound, Vector2 scale, Color color)
        {
            return this.Draw(sb, str.ToCharArray(), position, maxBound, scale, color);
        }

        public Vector2 Draw(SpriteBatch sb, char[] chars, Vector2 position, Vector2 maxBound, Vector2 scale, Color color)
        {
            if (maxBound.X == 0f)
            {
                maxBound.X = float.MaxValue;
            }
            else
            {
                maxBound.X += position.X;
            }
            if (maxBound.Y == 0f)
            {
                maxBound.Y = float.MaxValue;
            }
            else
            {
                maxBound.Y += position.Y;
            }
            Vector2 vector = position;
            float height = 0f;
            float x = 0f;
            int index = 0;
            int length = chars.Length;
            while (index < length)
            {
                char chr = chars[index];
                this.AddTex(chr);
                CharTile tile = this.CharTiles[chr];
                if ((chr == '\r') || ((vector.X + (tile.Rectangle.Width * scale.X)) > maxBound.X))
                {
                    if (vector.X > x)
                    {
                        x = vector.X;
                    }
                    vector.X = position.X;
                    vector.Y += (height * scale.Y) + (this.Spacing.Y * scale.X);
                    height = 0f;
                }
                else if (chr != '\n')
                {
                    if (tile.Rectangle.Height > height)
                    {
                        height = tile.Rectangle.Height;
                        if ((vector.Y + (height * scale.Y)) > maxBound.Y)
                        {
                            break;
                        }
                    }
                    if (sb != null)
                    {
                        sb.Draw(tile.Texture, vector, new Rectangle?(tile.Rectangle), color, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
                    }
                    vector.X += (tile.Rectangle.Width * scale.X) + (this.Spacing.X * scale.X);
                }
                index++;
            }
            if (vector.X > x)
            {
                x = vector.X;
            }
            vector.X = x - (this.Spacing.X * scale.X);
            vector.Y += height * scale.Y;
            return (vector - position);
        }

        private void Initialize(System.Drawing.Font font, IGraphicsDeviceService gds, System.Drawing.Text.TextRenderingHint trh)
        {
            this.font = font;
            this.GDS = gds;
            this.textRenderingHint = trh;
            if (brush == null)
            {
                brush = Brushes.White;
                tempBp = new Bitmap(1, 1);
                tempGr = System.Drawing.Graphics.FromImage(tempBp);
                strm = new MemoryStream();
            }
            this.CharTiles = new Dictionary<char, CharTile>();
            this.Tex2ds = new List<Texture2D>();
            this.newTex();
        }

        public Vector2 MeasureString(string str)
        {
            return this.MeasureString(str.ToCharArray());
        }

        public Vector2 MeasureString(char[] chars)
        {
            return this.Draw(null, chars, Vector2.Zero, Color.White);
        }

        public Vector2 MeasureString(string str, Vector2 maxBound, Vector2 scale)
        {
            return this.Draw(null, str, Vector2.Zero, maxBound, scale, Color.White);
        }

        public Vector2 MeasureString(char[] chars, Vector2 maxBound, Vector2 scale)
        {
            return this.Draw(null, chars, Vector2.Zero, maxBound, scale, Color.White);
        }

        protected void newTex()
        {
            this.CurrentTex2d = new Texture2D(this.GDS.GraphicsDevice, 0x100, 0x100);
            this.Tex2ds.Add(this.CurrentTex2d);
            this.CurrentTop = 0;
            this.CurrentLeft = 0;
            this.CurrentMaxHeight = 0;
        }

        public System.Drawing.Font Font
        {
            get
            {
                return this.font;
            }
        }

        public System.Drawing.Text.TextRenderingHint TextRenderingHint
        {
            get
            {
                return this.textRenderingHint;
            }
        }
    }
}
