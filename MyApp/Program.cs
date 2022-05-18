Console.WriteLine("Ingrese un numero: ");
double n = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor absoluto: {0}", Math.Abs(n));
Console.WriteLine("Cuadrado: {0}", Math.Pow(n, 2));
Console.WriteLine("Raiz cuadrada: {0}", Math.Sqrt(n));
Console.WriteLine("Seno: {0}", Math.Sin(n));
Console.WriteLine("Coseno: {0}", Math.Cos(n));
Console.WriteLine("Parte entera de un tipo float: {0}", Math.ReciprocalEstimate(n));

Console.WriteLine("A continuacion ingrese dos numeros");
double n1 = Convert.ToDouble(Console.ReadLine());
double n2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Maximo: {0}", Math.Max(n1, n2));
Console.WriteLine("Minimo: {0}", Math.Min(n1, n2));