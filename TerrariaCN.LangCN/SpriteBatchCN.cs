using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCN.IL
{
    public class SpriteBatchCN:SpriteBatch
    {
        SpriteFontX _sf;
        SpriteFontX _deathsfx;
        SpriteFont _deathsf;
        static SpriteBatchCN()
        {
           

        }
        public SpriteBatchCN(GraphicsDevice device):base(device)
        {
            GraphicsDeviceManager graphics = (GraphicsDeviceManager)typeof(Terraria.Main).GetField("graphics").GetValue(null);
            _sf = new SpriteFontX(new Font("微软雅黑", 14f), graphics, TextRenderingHint.ClearTypeGridFit);
            _deathsfx = new SpriteFontX(new Font("微软雅黑", 23f), graphics, TextRenderingHint.ClearTypeGridFit);
            //_deathsf = (SpriteFont)typeof(Terraria.Main).GetField("fontDeathText").GetValue(null);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color)
        {
            //sfx.
            _deathsf = (SpriteFont)typeof(Terraria.Main).GetField("fontDeathText").GetValue(null);
            if (_deathsf!=null&&_deathsf.Equals(sfx))
            {
                _deathsfx.Draw(this, str, position, color);
                return;
            }
             _sf.Draw(this, str, position, color);
        }

        public void DrawString(SpriteFont sfx, char[] chars, Vector2 position, Microsoft.Xna.Framework.Color color)
        {
            _sf.Draw(this, chars, position, color);
        }

        public void DrawString(SpriteFont sfx, string str, Vector2 position, Vector2 maxBound, Vector2 scale, Microsoft.Xna.Framework.Color color)
        {
            _sf.Draw(this, str, position, maxBound, scale, color);
        }

        public void DrawString(SpriteFont sfx, char[] chars, Vector2 position, Vector2 maxBound, Vector2 scale, Microsoft.Xna.Framework.Color color)
        {
            _sf.Draw(this, chars, position, maxBound, scale, color);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
        {
            _deathsf = (SpriteFont)typeof(Terraria.Main).GetField("fontDeathText").GetValue(null);
            if (_deathsf != null && _deathsf.Equals(sfx))
            {
                _deathsfx.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), scale, color);
                return;
            }
            _sf.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), scale, color);
        }

        public new void DrawString(SpriteFont sfx, string str, Vector2 position, Microsoft.Xna.Framework.Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
        {
            if (str=="弹药"|| str =="硬币")
            {
                if (position.X == 532f && position.Y == 65.1f)
                {
                    position.Y = 67.8f;
                }
                scale =0.8f;
            }else if(str == "设置")
            {
                if (position.X > 1800f && position.Y > 990f)
                {
                    scale = 1f;
                }
            }
            _deathsf = (SpriteFont)typeof(Terraria.Main).GetField("fontDeathText").GetValue(null);
            //_deathsfx.
            if (_deathsf != null && _deathsf.Equals(sfx))
            {
                _deathsfx.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), new Vector2(scale, scale), color);
                return;
            }
            // sfx.
            _sf.Draw(this, str, position - origin, new Vector2(float.MaxValue, float.MaxValue), new Vector2(scale, scale), color);
        }

        public static string toCN(string en)
        {
            string url = "http://apis.baidu.com/apistore/tranlateservice/translate";
            string param = "query="+ en+"&from=en&to=zh";
            string result = request(url, param);
            return result;
        }

        /// <summary>
        /// 发送HTTP请求
        /// </summary>
        /// <param name="url">请求的URL</param>
        /// <param name="param">请求的参数</param>
        /// <returns>请求结果</returns>
        public static string request(string url, string param)
        {
            string strURL = url + '?' + param;
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "GET";
            // 添加header
            request.Headers.Add("apikey", "ec3dedf550e5e6cea6c53385ed4f474a");
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                strValue += StrDate + "\r\n";
            }
            return strValue;
        }
    }
}
