// See https://aka.ms/new-console-template for more information
using CSScriptLib;
using System.Reflection;

// 编译方法
Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(
                        @"using System;
                          public static void CompileMethod(string greeting)
                          {
                              Console.WriteLine(""CompileMethod:"" + greeting);
                          }");
var p = compilemethod.GetType("css_root+DynamicClass");
var me = p.GetMethod("CompileMethod");
me.Invoke(null, new object[] { "1" });


// 装载方法
dynamic loadmethod = CSScript.Evaluator.LoadMethod(@"using System;
                          public void LoadMethod(string greeting)
                          {
                              Console.WriteLine(""LoadMethod:"" +greeting);
                          }");
// 数据这个方法
loadmethod.LoadMethod("Hello World!");


//dynamic loadcode = CSScript.Evaluator
// .LoadCode(@"using System;
//using CSScriptConsoleApp;
//using System.Text;
//public class ScriptCC
//{
//    public void LoadCode(string greeting)
//    {
//        Console.WriteLine(""LoadCode:"" + greeting);
//    }
//}");
//loadcode.LoadCode("111");

//var eval = CSScript.Evaluator.ReferenceDomainAssemblies(DomainAssemblies.AllStaticNonGAC);

//var ass = eval
//.CompileCode(@"using System;
//public static class ScriptCCStatic
//{
//    public static void LoadCodeStatic(string greeting)
//    {
//        Console.WriteLine(""LoadCodeStatic:"" + greeting);
//    }
//}");
//var tp = eval.CreateDelegate(@"int Sqr(int a)
//                                               {
//                                                   return a * a;
//                                               }");
//Console.WriteLine(tp(3));

//var eval = CSScript.Evaluator.ReferenceDomainAssemblies(DomainAssemblies.AllStaticNonGAC);

//eval = eval.ReferenceDomainAssemblies(DomainAssemblies.AllStaticNonGAC);

////查看evaluator的引用程序集
//var ww = eval.GetReferencedAssemblies();
//foreach (var n in ww)
//{
//    if (n.GetName().Name.Contains("System")) continue;
//    if (n.GetName().Name.Contains("Microsoft")) continue;
//    if (n.GetName().Name.Contains("CS")) continue;
//    Console.WriteLine("AseemblyName: " + n.GetName());
//    foreach (var wn in n.GetTypes())
//    {
//        Console.WriteLine("Types: " + wn.Name);
//    }
//}
//Console.WriteLine();

////查看当前AppDomain加载的程序集
//foreach (var n in AppDomain.CurrentDomain.GetAssemblies())
//{
//    if (n.GetName().Name.Contains("System")) continue;
//    if (n.GetName().Name.Contains("Microsoft")) continue;
//    if (n.GetName().Name.Contains("CS")) continue;
//    Console.WriteLine("AseemblyName: " + n.GetName());
//    foreach (var wn in n.GetTypes())
//    {
//        Console.WriteLine("Types: " + wn.Name);
//    }
//}

Console.ReadKey();
       

