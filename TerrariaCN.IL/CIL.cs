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
        public static void ReadAM()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var asm = AssemblyDefinition.ReadAssembly("TerrariaEN.exe");
            
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

            var h = typeMain.Fields.FirstOrDefault(m => m.Name == "spriteBatch");
            h.FieldType = spriteType;

            var loadContentMethod = typeMain.Methods.FirstOrDefault(m => m.Name == "LoadContent");

            var graphicsDevice = loadContentMethod.Body.Instructions.FirstOrDefault(m => m.OpCode == OpCodes.Newobj && ((MethodReference)m.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::.ctor(Microsoft.Xna.Framework.Graphics.GraphicsDevice)");

            if (graphicsDevice!=null)
            { 
               var loadContentWorker = loadContentMethod.Body.GetILProcessor();
               loadContentWorker.Replace(graphicsDevice, loadContentWorker.Create(OpCodes.Newobj, ctor));
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
                            //item.Operand = "劫持了";
                        }
                    }
                    

                    continue;
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

            using (TextWriter tw = File.CreateText("en.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }
               
            asm.Write("TerrariaCN.exe");
        }
    }
}
