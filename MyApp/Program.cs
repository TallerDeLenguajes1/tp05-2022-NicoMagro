//Construir un programa que permita invertir Número de N cifras.
// Si el número es menor o igual a cero evitar esta conversión

// Console.WriteLine("Ingrese un numero para invertirlo");
// char[] array = Console.ReadLine().ToCharArray();

// while (Convert.ToInt32(array) <= 0)
// {
//     Console.WriteLine("Numero no valido, ingrese un numero positivo");
//     array = Console.ReadLine().ToCharArray();
// }
// Array.Reverse(array);

// string n = new string(array);

// Console.WriteLine(n);

Console.Write("Ingrese un número: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (numero <= 0)
{
    Console.WriteLine("Numero no valido, ingresar un numero positivo");
    numero = Convert.ToInt32(Console.ReadLine());
}

var invertido = new string("");

foreach (char c in Convert.ToString(numero))
{
    invertido = c + invertido;
}

Console.WriteLine("El numero invertido es: " + invertido);