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
    public class Class1
    {
        public static void ReadAM()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var asm = AssemblyDefinition.ReadAssembly("TerrariaEN.exe");
            asm.Modules.Add(ModuleDefinition.ReadModule("TerrariaCN.LangCN.dll"));

            var tpep2 = asm.MainModule.Import(typeof(SpriteFontX));


            var tpep = asm.MainModule.Import(typeof(SpriteBatchCN));
            var ppp = tpep.Resolve().Methods[7];
            var ppp1 = asm.MainModule.Import(ppp);

            var ppp3 = asm.MainModule.Import(tpep.Resolve().Methods[2]);

            var ppp4 = asm.MainModule.Import(tpep.Resolve().Methods[3]);

            var ppp5 = asm.MainModule.Import(tpep.Resolve().Methods[4]);

            var ppp6 = asm.MainModule.Import(tpep.Resolve().Methods[5]);

            var ppp7 = asm.MainModule.Import(tpep.Resolve().Methods[6]);

            var ppp2 = asm.MainModule.Import(tpep.Resolve().Methods[1]);
            var langasm = AssemblyDefinition.ReadAssembly("TerrariaCN.LangCN.dll");
            var langtype = asm.Modules[1].Types.FirstOrDefault(m => m.Name == "Lang");


            var typeMain = asm.MainModule.Types.FirstOrDefault(m => m.Name == "Main");

            var h = typeMain.Fields.FirstOrDefault(m => m.Name == "spriteBatch");
            h.FieldType = tpep;

            var h1 = typeMain.Methods.FirstOrDefault(m => m.Name == "LoadContent");

            var h2 = h1.Body.Instructions.FirstOrDefault(m => m.OpCode == OpCodes.Newobj && ((MethodReference)m.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::.ctor(Microsoft.Xna.Framework.Graphics.GraphicsDevice)");

            var h3 = h1.Body.GetILProcessor();

            // h2.Operand = ppp2;
            // h3.InsertBefore(h2, h3.Create(OpCodes.Stsfld, h));
            h3.Replace(h2, h3.Create(OpCodes.Newobj, ppp2));
            // h3.Remove(h2);



           // var type = asm.MainModule.Types.FirstOrDefault(m => m.Name == "Lang");
           //// var langmethod = langtype.Methods.FirstOrDefault(m => m.Name == "title");
           // var method = type.Methods.FirstOrDefault(m => m.Name == "setLang");
           // Instruction ins = method.Body.Instructions[0];
           // var worker = method.Body.GetILProcessor();


           // // worker.InsertBefore(ins, sss22);
           // //  langasm.MainModule.

           // var callUnauthorized = method
           //     .Body
           //     .Instructions
           //     .Where(i =>
           //         i.OpCode == OpCodes.Ldstr
           //         ).ToList();
           // foreach (var item in callUnauthorized)
           // {
           //     item.Operand = "劫持了";
           // }

            foreach (var typeaaa in asm.MainModule.Types)
            {
                if (typeaaa.Name=="Lang")
                {
                    foreach (var method in typeaaa.Methods)
                    {
                        //var method = typeaaa.Methods.FirstOrDefault(m => m.Name == "setLang");
                        Instruction ins = method.Body.Instructions[0];
                        var worker = method.Body.GetILProcessor();


                        // worker.InsertBefore(ins, sss22);
                        //  langasm.MainModule.

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

                foreach (var mmmm in typeaaa.Methods)
                {
                    if (!mmmm.HasBody)
                    {
                        continue;
                    }
                    var s = mmmm.Body.Instructions.Where(m => m.OpCode == OpCodes.Callvirt && ((MethodReference)m.Operand).Name == "DrawString").ToList();
                    if (s.Count != 0)
                    {


                        var wo1 = mmmm.Body.GetILProcessor();
                        //s[7].Operand = ppp1;
                        foreach (var opop in s)
                        {
                            if (((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color,System.Single,Microsoft.Xna.Framework.Vector2,System.Single,Microsoft.Xna.Framework.Graphics.SpriteEffects,System.Single)")
                            {
                                var sss22 = wo1.Create(OpCodes.Callvirt, ppp1);

                                //s[7]
                                wo1.Replace(opop, sss22);
                            }
                            else if(((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color)")
                            {
                                var sss22 = wo1.Create(OpCodes.Callvirt, ppp3);

                                //s[7]
                                wo1.Replace(opop, sss22);
                            }
                            else if (((MethodReference)opop.Operand).FullName == "System.Void Microsoft.Xna.Framework.Graphics.SpriteBatch::DrawString(Microsoft.Xna.Framework.Graphics.SpriteFont,System.String,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Color,System.Single,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Vector2,Microsoft.Xna.Framework.Graphics.SpriteEffects,System.Single)")
                            {
                                var sss22 = wo1.Create(OpCodes.Callvirt, ppp7);

                                //s[7]
                                wo1.Replace(opop, sss22);
                            }
                            else
                            {

                            }
                        }

                        //foreach (var t in s)
                        //{
                        //    t.Operand = refernce;
                        //}
                        //s[7].Operand = refernce;
                    }
                }
            }

            TextWriter tw = File.CreateText("perl.json");
            var sds = Newtonsoft.Json.JsonSerializer.Create();
            sds.Serialize(tw, dic);
            tw.Close();
            asm.Write("TerrariaCN.exe");
        }
    }
}
