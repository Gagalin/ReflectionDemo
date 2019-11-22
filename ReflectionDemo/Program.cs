using System;
using System.Configuration;
using System.Reflection;
using System.Reflection.Emit;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string IDBHelperConfig = ConfigurationManager.AppSettings["IUseHelper"];
            string DllName = IDBHelperConfig.Split(',')[1];
            string TypeName = IDBHelperConfig.Split(',')[0];
            Assembly assembly = Assembly.Load(DllName);
            Type type = assembly.GetType(TypeName);
            object oDBHelper = Activator.CreateInstance(type);
        }
    }
}
