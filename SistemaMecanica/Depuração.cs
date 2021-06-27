using System;
using System.Activities;
using System.Reflection;

class Depuração { 
public static void Teste() {
    Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
    Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
    Console.WriteLine(System.Environment.CurrentDirectory);
    Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
    Console.WriteLine(Environment.CurrentDirectory);
    
}
}