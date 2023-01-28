using System;
using System.Reflection;
using JavaCommons;
namespace CUI;
public static class Program
{
    public static void Main(string[] args)
    {
        Util.Print(Environment.Version.ToString(), "Runtime Version");
        Util.Print(Assembly.GetExecutingAssembly().GetName().Version.ToString(), "Assembly Version");
        Util.Print(args, "args");
        var engine = JavaScript.CreateEngine();
        engine.Execute("Util.Print(123.45);");
        engine.Execute("function add(a, b) { return a + b; }");
        var sum = engine.Invoke("add", 11, 22).FromObject();
        Util.Print(sum);
    }
}
