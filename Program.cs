// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tarea 1 Estructura de Datos");
Console.WriteLine("Estudiante: Malcon Loaiza Vega");
Console.WriteLine("\n");

int[] Arreglo1 = new int[5];
int[] Arreglo2 = new int[5];
int[] numerosOrdenados = new int[10];

Console.Write("Ingrese 5 números para completar el primer arreglo");
Console.WriteLine("\n");

for (int i = 0; i < Arreglo1.Length; i++)
{
    
    Console.Write("Ingrese el número {0}: ", i + 1);
    Arreglo1[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n");
Console.Write("Ingrese 5 números para completar el segundo arreglo");
Console.WriteLine("\n");

for (int i = 0; i < Arreglo2.Length; i++)
{
   
    Console.Write("Ingrese el número {0}: ", i + 1);
    Arreglo2[i] = int.Parse(Console.ReadLine());
}

Array.Copy(Arreglo1, numerosOrdenados, Arreglo1.Length);
Array.Copy(Arreglo2, 0, numerosOrdenados, Arreglo1.Length, Arreglo2.Length);

Array.Sort(numerosOrdenados);
Array.Reverse(numerosOrdenados);

Console.WriteLine("\n");
Console.WriteLine("Se presenta el arreglo ascendentemente:");

// Imprimir los números ordenados por pantalla
foreach (int numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}