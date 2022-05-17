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
Console.WriteLine("Rama 2");