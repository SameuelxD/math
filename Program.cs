using System.Collections;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine(Math.Max(45,101)); /* La clase Math con metodo Max retorna el numero mas alto de los argumentos max = 101 
        Console.WriteLine(Math.Min(45,101)); /* La clase Math con metodo Min retorna el numero mas bajo de los argumentos min = 45 
        Console.WriteLine(Math.Pow(5,3)); /* La clase Math con metodo Pow coge el primer numero y lo eleva su segundo como exponente 5**3 = 125 
        Console.WriteLine(Math.Sqrt(16)); /* La clase Math con metodo Sqrt retorna la raiz de dicho numero 4 
        Console.WriteLine(Math.Sqrt(17)); /* La clase Math con metodo Sqrt tambien retornara decimales si es necesaario 4.123105 
        Console.WriteLine(Math.PI); /* Retorna el valor de PI 

        double numero = 3.4681;
        Console.WriteLine(Math.Round(numero)); /* Round evalua  si el numero en que comienza la parte decimal es >=5 lo reondea una unidad , si es menor lo redondeara para abajo 
        Console.WriteLine(Math.Ceiling(numero)); /* Ceiling siempre redondeara cualquier valor de mayor o menor de 5 para arriba le va a agregar una unidad si es un decimal cualquiera 
        Console.WriteLine(Math.Floor(numero)); /* Floor siempre redondeara cualquier valor mayor o menor de 5 para abajo le va a restar una unidad si es un decimal cualquiera
        Console.WriteLine(Math.Abs(-123)); /* Retornara el valor absoluto es decir siempre un numero positivio */
        List<String> Materias = new List<String>();
        int idx;
        Materias.Add("Calculo");
        Materias.Add("Español");
        Materias.Add("Dibujo Tecnico");
        Materias.Add("Ingles");
        ContarLista(Materias);
        Console.WriteLine("Ingrese la posicion {0}");
        idx=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El elemento es el indice {0} es: {1} ", idx,ObtenerElemento(idx,Materias));
        Materias.Add(AddItemData());
        Console.WriteLine("Ingrese la palabra a buscar");
        if(ValidarItem(Materias,Console.ReadLine().ToLower())){
            Console.WriteLine("Ok , lo Encontre");
        }else{
            Console.WriteLine("No lo encontre");  // Los metodos de una clase sirven para definir comportamientos de la misma y me permite modificar su uso 
        }
        string dino;
        string[] Dinos = {
                            "Brachiosaurus","Amargasaurus","Mamenchisaurus"                    
                            };
        Console.WriteLine("Ingrese el nombre del Dinosairoio a buscar: ");
        dino=Console.ReadLine();
        string ? nombre = Dinos.Find(n => n.StartsWith(palabra ?? String.Empty));
        Console.WriteLine(nombre != null ? "Se encontro el Dinosaurio" : "No se encontro el Dinosaurio");
    }
    public static void ContarLista(List<String> lista){
        Console.WriteLine("Total elementos de la lista {0} " , lista.Count());
    }
    public static string AddItemData(){
        Console.WriteLine("Ingrese el titulo del elemento");
        return Console.ReadLine();
    }

    /// <summary>
    /// Metodo para obtener el elemento de una posicion de una lista generica
    /// </summary>
    /// <param name="idx"></param>
    /// <param name="lista"></param>
    /// <returns></returns>
    public static string ObtenerElemento(int idx,List<String> lista){
        return lista[idx];
    }
    public static bool ValidarItem(List<String> lista,string valor){
        return lista.Exists(l => l.ToLower().Equals(valor));
    }
}
