// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese un texto: ");
string texto = Console.ReadLine();
Console.WriteLine("Ingrese un numero: ");
string numero = Console.ReadLine();
Console.WriteLine("Ingrese otro numero: ");
string numero1 = Console.ReadLine();
int resultado = Int32.Parse(numero) + Convert.ToInt32(numero1);
Console.WriteLine("Usted escribio " + texto + numero + numero1);
Console.WriteLine("el resultado es: " + resultado);
EscribeUnaLinea();
Console.WriteLine("Hola Mundo!");
Console.WriteLine("Usted escribio " + texto);
int cuadrados = cuadrado(Convert.ToInt32(numero));
Console.WriteLine("El cuadrado del numero 1 es: " + cuadrados);


int cuadrado(int a)
{
    return a*a;
}

void EscribeUnaLinea()
{
    Console.WriteLine("Escribe una linea");
}