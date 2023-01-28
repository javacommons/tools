using Microsoft.ClearScript.V8;
public class JavaScript
{
    public static V8ScriptEngine CreateEngine()
    {
        var engine = new V8ScriptEngine();
        engine.AddHostType("Util", typeof(JavaCommons.Util));
        return engine;
    }
}
