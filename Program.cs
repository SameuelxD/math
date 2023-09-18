using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> openWith = new Dictionary<string, string>(); /* Declaracion de un nuevo diccionario */
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");
        bool flag=true;
        while(flag){
            Console.Clear();
            Console.WriteLine("-------------------- MENU --------------------");
            Console.WriteLine("   1. Buscar elemento con la llave. ");
            Console.WriteLine("   2. Mostrar Valores y Claves. ");
            Console.WriteLine("   3. Mostrar Valores. ");
            Console.WriteLine("   4. Agregar Elementos. ");
            Console.WriteLine("   5. Limpiar Consola Clear. ");
            Console.WriteLine("   6. ContainsKey. ");
            Console.WriteLine("   7. ContainsValue. ");
            Console.WriteLine("   8. Remove. ");
            Console.WriteLine("Ingrese la opcion: ");
            int opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    Console.Clear();
                    try
                    {
                        openWith.Add("txt", "winword.exe");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Un elemento con la llave = \"txt\" ya existe.");
                    }
                    
                    Console.WriteLine("El total de los elementos del diccionario es: {0}", openWith.Count);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    Dictionary<string,string>.KeyCollection keyColl = openWith.Keys; 
                    foreach(string key in keyColl){
                        Console.WriteLine(key);
                    }
                    foreach(KeyValuePair<string,string> pair in openWith){
                        Console.WriteLine("Llave {0} - Valor {1}",pair.Key,pair.Value);
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Dictionary<string,string>.ValueCollection valueColl=openWith.Values;
                    foreach(string valor in valueColl){
                        Console.WriteLine(valor);
                    }
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Ingrese el valor y la clave para agregar al diccionario: ");
                    string keys=Console.ReadLine();
                    string values=Console.ReadLine();
                    openWith.Add(keys,values);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Elementos antes del Clear: {0}", openWith.Count);
                    Console.WriteLine("Limpiando Consola");
                    Console.WriteLine("Elementos despues del Clear: {0}", openWith.Count);
                    openWith.Clear();
                    break;
                case 6:
                    if(openWith.ContainsKey("bmp")){
                        Console.WriteLine("El tipo de formato esta soportado.");
                    }
                    Dictionary<string,string>.ValueCollection valueCol=openWith.Values;
                    foreach(string val in valueCol){
                        Console.WriteLine(val);
                    }
                    Console.ReadLine();
                    break;
                case 7:
                    if(openWith.ContainsValue("notepad")){
                        Console.WriteLine("El valor se encuentra registrado.");
                    }else{
                        Console.WriteLine("El valor no se encuentra registrado- ");
                    }
                    Dictionary<string,string>.ValueCollection valorColl=openWith.Values;
                    foreach(string valor in valorColl){
                        Console.WriteLine(valor);
                    }
                    Console.ReadLine();
                    break;
                    case 8:
                        Console.WriteLine("Ingrese el elemento a elininar: ");
                        string elemet= Console.ReadLine();
                        openWith.Remove(elemet);
                        break;
                default:
                    Console.Clear();
                    flag=false;
                    break;
            }
        }
    }
}
