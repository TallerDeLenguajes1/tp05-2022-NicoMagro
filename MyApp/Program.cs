//     int calculadora = 1;
//     while (calculadora == 1)
//     {
//         Console.WriteLine("Ingrese dos numeros");
//         Console.WriteLine("Ingrese el primer numero: ");
//         int n1 = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Ingrese el segundo numero: ");
//         int n2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Que desea hacer?");
//         Console.WriteLine("Presione 1 para realizar una suma");
//         Console.WriteLine("Presione 2 para realizar una resta");
//         Console.WriteLine("Presione 3 para realizar una multiplicacion");
//         Console.WriteLine("Presione 4 para realizar una division");

//         Console.WriteLine("Ingrese una opcion: ");
//         int operacion = Convert.ToInt32(Console.ReadLine());
//         while (operacion <= 0 || operacion > 4)
//         {
//             Console.WriteLine("Ingrese una opcion correcta");
//             operacion = Convert.ToInt32(Console.ReadLine());
//         }

//         int resultado;
//         switch (operacion)
//         {
//             case 1:
//                 resultado = sumar(n1, n2);
//                 Console.WriteLine("El resultado de sumar ambos numeros es: " + resultado);
//             break;
//             case 2:
//                 resultado = restar(n1, n2);
//                 Console.WriteLine("El resultado de restar ambos numeros es: " + resultado);
//             break;
//             case 3:
//                 resultado = multiplicar(n1, n2);
//                 Console.WriteLine("El resultado de multiplicar ambos numeros es: " + resultado);
//             break;
//             case 4: 
//                 resultado = dividir(n1, n2);
//                 Console.WriteLine("El resultado de dividir ambos numeros es: " + resultado);
//             break;
//         }

//         Console.WriteLine("Pulse 1 si realizara otra operacion, sino pulse cualquier numero");
//         calculadora = Convert.ToInt32(Console.ReadLine());

//         if (calculadora != 1)
//         {
//             Console.WriteLine("Muchas gracias por usar la calculadora :)");
//         }
//     }


//     int sumar(int n1, int n2)
//     {
//         return n1+n2;
//     }

//     int restar(int n1, int n2)
//     {
//         return n1-n2;
//     }

//     int multiplicar(int n1, int n2)
//     {
//         return n1*n2;
//     }

//     int dividir(int n1, int n2)
//     {
//         return n1/n2;
//     }

//     //Console.WriteLine("Chau V1");
//     Console.WriteLine("Ingrese un numero: ");
//     double n = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Valor absoluto: {0}", Math.Abs(n));
//     Console.WriteLine("Cuadrado: {0}", Math.Pow(n, 2));
//     Console.WriteLine("Raiz cuadrada: {0}", Math.Sqrt(n));
//     Console.WriteLine("Seno: {0}", Math.Sin(n));
//     Console.WriteLine("Coseno: {0}", Math.Cos(n));
//     Console.WriteLine("Parte entera de un tipo float: {0}", Math.Truncate(n));

//     Console.WriteLine("A continuacion ingrese dos numeros");
//     double n3 = Convert.ToDouble(Console.ReadLine());
//     double n4 = Convert.ToDouble(Console.ReadLine());

//     Console.WriteLine("Maximo: {0}", Math.Max(n3, n4));
//     Console.WriteLine("Minimo: {0}", Math.Min(n3, n4));   
// //Console.WriteLine("Chau V2");

Console.WriteLine("Obtener algunas letras de una cadena");
string cadena = Console.ReadLine();

Console.WriteLine("Algunas letras: {0}, {1}, {2}", cadena[1], cadena[3], cadena[4]);

int longitud = 0;

foreach (char c in cadena)
{
    longitud++;
}

Console.WriteLine("La longitud de la cadena es: {0}", longitud);