using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DumpCNConsoleApplication
{
    class Program
    {
        static MethodReference GetMethod(TypeDefinition td,string name)
        {
            return td.Methods.FirstOrDefault(m => m.Name == name);

        }

        static Dictionary<string,string> GetInDic(string name= "Terraria.exe")
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var asm = AssemblyDefinition.ReadAssembly(name);
            var cntype = asm.MainModule.Types.FirstOrDefault(m => m.Name == "Lang");
            var method = cntype.Methods.FirstOrDefault(m => m.Name == "setLang");
            int i = 0;
            foreach(var m in method.Body.Instructions)
            {
                if (m.OpCode == OpCodes.Ldsfld && ((FieldReference)m.Operand).FullName == "System.Int32 Terraria.Lang::lang")
                {
                    if (i > 0)
                    {
                        //using (TextWriter tw = File.CreateText(method.Name + "en.json"))
                        //{
                        //    var sds = Newtonsoft.Json.JsonSerializer.Create();
                        //    sds.Serialize(tw, tempDic);
                        //    tw.Close();

                        i = 0;

                        break;
                    }
                    i++;
                }

                if (m.OpCode == OpCodes.Ldstr && ((string)m.Operand) != "")
                {
                    if (m.Previous.OpCode==OpCodes.Call)
                    {
                        string key = ((MethodReference)m.Previous.Operand).Name + "." + GetCodeStr(m.Previous.Previous.Previous) + "." + GetCodeStr(m.Previous.Previous);
                        string res = m.Operand.ToString();
                        if ((string)dic.Keys.FirstOrDefault(j => j == key) == null)
                        {
                            dic.Add(key, res);
                        }
                    }
                    else if  (m.Previous.Previous.OpCode == OpCodes.Ldsfld)
                    {
                        string key = ((FieldReference)m.Previous.Previous.Operand).Name + "." + GetCodeStr(m.Previous);
                        string res = m.Operand.ToString();
                        if ((string)dic.Keys.FirstOrDefault(j => j == key) == null)
                        {
                            dic.Add(key, res);
                        }
                        
                    }
                }
            }
          //  var strlist = method.Body.Instructions.Where(m => m.OpCode == OpCodes.Ldstr && ((string)m.Operand) != "");
            return dic;
        }

        static string GetCodeStr(Instruction ins)
        {
            if (ins.OpCode == OpCodes.Ldc_I4)
            {
                return ins.Operand.ToString();
            }
            if (ins.OpCode==OpCodes.Ldc_I4_S)
            {
                return ins.Operand.ToString();
            }
            if (ins.OpCode == OpCodes.Ldc_I4_0)
            {
                return "0";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_1)
            {
                return "1";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_2)
            {
                return "2";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_3)
            {
                return "3";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_4)
            {
                return "4";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_5)
            {
                return "5";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_6)
            {
                return "6";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_7)
            {
                return "7";
            }
            if (ins.OpCode == OpCodes.Ldc_I4_8)
            {
                return "8";
            }

            return "";
        }
        static void Main(string[] args)
        {
            //GetInDic
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var endic=GetInDic();

            var cndic = GetInDic("TerrariaCN.exe");

            foreach(var item in cndic)
            {
                if (endic.Keys.FirstOrDefault(m=>m== item.Key)!=null && (string)dic.Keys.FirstOrDefault(m => m == endic[item.Key]) == null)
                {
                    dic.Add(endic[item.Key], item.Value);
                }
            }
            using (TextWriter tw = File.CreateText("setLang" + "CN.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }
            dic = new Dictionary<string, string>();

            for (int i=-65;i<540;i++)
            {
                string s = NpcName.en(i);
                if ((string)dic.Keys.FirstOrDefault(m => m ==s) == null)
                {
                    dic.Add(s, NpcName.cn(i));
                }
            }
            using (TextWriter tw = File.CreateText("npcName"+ "CN.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }
            dic = new Dictionary<string, string>();

            for (int i = 0; i < 4000; i++)
            {
                string s = toolTip.en(i);
                if ((string)dic.Keys.FirstOrDefault(m => m == s) == null)
                {
                    dic.Add(s, toolTip.cn(i));
                }
            }
            using (TextWriter tw = File.CreateText("toolTip" + "CN.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }

            dic = new Dictionary<string, string>();

            for (int i = 0; i < 4000; i++)
            {
                string s = toolTip2.en(i);
                if ((string)dic.Keys.FirstOrDefault(m => m == s) == null)
                {
                    dic.Add(s, toolTip2.cn(i));
                }
            }
            using (TextWriter tw = File.CreateText("toolTip2" + "CN.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }

            dic = new Dictionary<string, string>();

            for (int i = 0; i < 50; i++)
            {
                string s = setBonus.en(i);
                if ((string)dic.Keys.FirstOrDefault(m => m == s) == null)
                {
                    dic.Add(s, setBonus.cn(i));
                }
            }
            using (TextWriter tw = File.CreateText("setBonus" + "CN.json"))
            {
                var sds = Newtonsoft.Json.JsonSerializer.Create();
                sds.Serialize(tw, dic);
                tw.Close();
            }



            //var asmen = AssemblyDefinition.ReadAssembly("Terraria.exe");

            //var asmcn = AssemblyDefinition.ReadAssembly("TerrariaCN.exe");

            //var cntype = asmcn.MainModule.Types.FirstOrDefault(m => m.Name == "Lang");

            //foreach (var type in asmen.MainModule.Types)
            //{
            //    if (type.Name == "Lang")
            //    {
            //        foreach (var method in type.Methods)
            //        {
            //            List<string> cnlist, enlist;
            //            cnlist = new List<string>();
            //            enlist = new List<string>();
            //            Dictionary<string, string> dic = new Dictionary<string, string>();

            //            if (method.Name == "npcName")
            //            {
            //                int i = 0;


            //                foreach (var item in GetMethod(cntype, method.Name).Resolve().Body.Instructions)
            //                {
            //                    if (item.OpCode == OpCodes.Ldsfld && ((FieldReference)item.Operand).FullName == "System.Int32 Terraria.Lang::lang")
            //                    {
            //                        if (i > 0)
            //                        {
            //                            i = 0;
            //                            break;
            //                        }
            //                        i++;
            //                    }
            //                    if (item.OpCode == OpCodes.Ldstr)
            //                    {
            //                        cnlist.Add(item.ToString());
            //                    }


            //                }
            //                 foreach (var item in method.Body.Instructions)
            //                {

            //                    if (item.OpCode == OpCodes.Ldsfld && ((FieldReference)item.Operand).FullName == "System.Int32 Terraria.Lang::lang")
            //                    {
            //                        if (i > 0)
            //                        {
            //                            i = 0;
            //                            break;
            //                        }
            //                        i++;
            //                    }
            //                    if (item.OpCode == OpCodes.Ldstr)
            //                    {
            //                        enlist.Add(item.ToString());
            //                    }

            //                }

            //                //int h = 0;
            //                for (int h=0;h< cnlist.Count;i++)
            //                {
            //                    if ((string)dic.Keys.FirstOrDefault(m => m == enlist[h]) == null)
            //                    {
            //                        dic.Add(enlist[h], cnlist[h]);
            //                    }

            //                }


            //            }
            //          }
            //        }

            //}
        }
    }
}
