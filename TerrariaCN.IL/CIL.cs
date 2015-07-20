using Microsoft.Xna.Framework;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaCN.IL
{
    public class CIL
    {
        public class ProgressChangedEventArgs:EventArgs
        {
            public int ProgressPer;

            public string Message;

        }

        public delegate void ProgressChanged(object sender, ProgressChangedEventArgs Args);

        public event ProgressChanged OnProgressChanged;


        public  void ReadAM()
        {

            Dictionary<string, string> CNDic;
            using (StringReader sr = new StringReader(File.ReadAllText("cn.json")))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                CNDic=(Dictionary<string, string>)sds.Deserialize(sr, typeof(Dictionary<string, string>));
                sr.Close();
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            var asm = AssemblyDefinition.ReadAssembly("Terraria.exe");

            var gameType = asm.MainModule.Import(typeof(LangCN.Game));

            //asm.MainModule.Import(typeof(GraphicsDeviceManager));

            var gameupdate = asm.MainModule.Import(gameType.Resolve().Methods[2]);

            //设置方法引用
            var spriteType = asm.MainModule.Import(typeof(SpriteBatchCN));

            var drawString6 = asm.MainModule.Import(spriteType.Resolve().Methods[7]);

            var drawString1 = asm.MainModule.Import(spriteType.Resolve().Methods[2]);

            var drawString2 = asm.MainModule.Import(spriteType.Resolve().Methods[3]);

            var drawString3 = asm.MainModule.Import(spriteType.Resolve().Methods[4]);

            var drawString4 = asm.MainModule.Import(spriteType.Resolve().Methods[5]);

            var drawString5 = asm.MainModule.Import(spriteType.Resolve().Methods[6]);

            var ctor = asm.MainModule.Import(spriteType.Resolve().Methods[1]);

            var typeMain = asm.MainModule.Types.FirstOrDefault(m => m.Name == "Main");

            typeMain.BaseType = gameType;

            var h2 = typeMain.Methods.FirstOrDefault(m => m.Name == "Update");
            var wh2=h2.Body.GetILProcessor();
            //wh2.InsertBefore(h2.Body.Instructions[0], wh2.Create(OpCodes.Ldarg_0));
            wh2.InsertBefore(h2.Body.Instructions[0], wh2.Create(OpCodes.Call, gameupdate));
            // wh2.InsertBefore(h2.Body.Instructions[0], wh2.Create(OpCodes.Ldarg_0));

            var h = typeMain.Fields.FirstOrDefault(m => m.Name == "spriteBatch");
            h.FieldType = spriteType;

            //var h2 = typeMain.Fields.FirstOrDefault(m => m.Name == "graphics");
            //typeMain.Fields.Remove(h2);

            var loadContentMethod = typeMain.Methods.FirstOrDefault(m => m.Name == "LoadContent");

            var graphicsDevice = loadContentMethod.Body.Instructions.FirstOrDefault(m => m.OpCode == OpCodes.Newobj && ((MethodReference)m.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::.ctor(Microsoft.Xna.Framework.Graphics.GraphicsDevice)");

            if (graphicsDevice!=null)
            { 
               var loadContentWorker = loadContentMethod.Body.GetILProcessor();
               loadContentWorker.Replace(graphicsDevice, loadContentWorker.Create(OpCodes.Newobj, ctor));
            }


            if (OnProgressChanged != null)
            {
                OnProgressChanged(this, new ProgressChangedEventArgs() { ProgressPer = 5, Message = "完成模块解析及导入" });
            }

            foreach (var type in asm.MainModule.Types)
            {
                if (type.Name=="Lang")
                {
                    foreach (var method in type.Methods)
                    {

                        Instruction ins = method.Body.Instructions[0];
                        var worker = method.Body.GetILProcessor();

                        var callUnauthorized = method
                            .Body
                            .Instructions
                            .Where(i =>
                                i.OpCode == OpCodes.Ldstr
                                ).ToList();
                        foreach (var item in callUnauthorized)
                        {
                            if ((string)dic.Keys.FirstOrDefault(m => m == item.Operand.ToString())==null)
                            {
                                dic.Add(item.Operand.ToString(), item.Operand.ToString());
                            }
                            if ((string)CNDic.Keys.FirstOrDefault(m => m == item.Operand.ToString()) != null)
                            {
                                item.Operand = CNDic[CNDic.Keys.FirstOrDefault(m => m == item.Operand.ToString())];
                            }
                            //item.Operand = "劫持了";
                        }
                    }
                    

                    continue;
                }

                if (OnProgressChanged != null)
                {
                    OnProgressChanged(this, new ProgressChangedEventArgs() { ProgressPer = 40, Message = "完成文本替换" });
                }

                foreach (var method in type.Methods)
                {
                    if (!method.HasBody)
                    {
                        continue;
                    }
                    var s = method.Body.Instructions.Where(m => m.OpCode == OpCodes.Callvirt && ((MethodReference)m.Operand).Name == "DrawString").ToList();
                    if (s.Count != 0)
                    {
                        var worker = method.Body.GetILProcessor();
                        //s[7].Operand = ppp1;
                        foreach (var opop in s)
                        {
                            if (((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color,System.Single,Microsoft.Xna.Framework.Vector2,System.Single,Microsoft.Xna.Framework.Graphics.SpriteEffects,System.Single)")
                            {
                                var sss22 = worker.Create(OpCodes.Callvirt, drawString6);

                                //s[7]
                                worker.Replace(opop, sss22);
                            }
                            else if(((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color)")
                            {
                                var sss22 = worker.Create(OpCodes.Callvirt, drawString1);

                                //s[7]
                                worker.Replace(opop, sss22);
                            }
                            else if (((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color,System.Single,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteEffects,System.Single)")
                            {
                                var sss22 = worker.Create(OpCodes.Callvirt, drawString5);

                                //s[7]
                                worker.Replace(opop, sss22);
                            }
                            else
                            {

                            }
                        }

                    }
                }
            }
            if (OnProgressChanged != null)
            {
                OnProgressChanged(this, new ProgressChangedEventArgs() { ProgressPer = 85, Message = "完成模块函数劫持" });
            }
            using (TextWriter tw = File.CreateText("en.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }

            if (OnProgressChanged != null)
            {
                OnProgressChanged(this, new ProgressChangedEventArgs() { ProgressPer = 90, Message = "完成文本导出，请在根目录查看EN.JSON文件" });
            }

            asm.Write("TerrariaCN.exe");
            if (OnProgressChanged != null)
            {
                OnProgressChanged(this, new ProgressChangedEventArgs() { ProgressPer = 100, Message = "全部完成，请改名TerrariaCN.exe为Terraria.exe 并同TerrariaCN.LangCN.dll一起复制到游戏目录" });
            }
        }
    }
}
