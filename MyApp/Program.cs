Console.WriteLine("Ingrese una cadena");
string cadena = Console.ReadLine();
int longitud = 0;
foreach (char c in cadena)
{
    longitud++;
}
Console.WriteLine("Longitud de la cadena: {0}", longitud);
Console.WriteLine("Ingrese otra cadena");
string cadena2 = Console.ReadLine();
String cadena3 = cadena + " " + cadena2;
Console.WriteLine("La cadena concatenada quedo: {0}", cadena3);