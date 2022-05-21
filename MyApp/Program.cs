int calculadora = 1;
while (calculadora == 1)
{
    Console.WriteLine("Ingrese dos numeros");
    Console.WriteLine("Ingrese el primer numero: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Que desea hacer?");
    Console.WriteLine("Presione 1 para realizar una suma");
    Console.WriteLine("Presione 2 para realizar una resta");
    Console.WriteLine("Presione 3 para realizar una multiplicacion");
    Console.WriteLine("Presione 4 para realizar una division");

    Console.WriteLine("Ingrese una opcion: ");
    int operacion = Convert.ToInt32(Console.ReadLine());
    while (operacion <= 0 || operacion > 4)
    {
        Console.WriteLine("Ingrese una opcion correcta");
        operacion = Convert.ToInt32(Console.ReadLine());
    }

    int resultado;
    switch (operacion)
    {
        case 1:
            resultado = sumar(n1, n2);
            Console.WriteLine("El resultado de sumar ambos numeros es: " + resultado);
        break;
        case 2:
            resultado = restar(n1, n2);
            Console.WriteLine("El resultado de restar ambos numeros es: " + resultado);
        break;
        case 3:
            resultado = multiplicar(n1, n2);
            Console.WriteLine("El resultado de multiplicar ambos numeros es: " + resultado);
        break;
        case 4: 
            resultado = dividir(n1, n2);
            Console.WriteLine("El resultado de dividir ambos numeros es: " + resultado);
        break;
    }

    Console.WriteLine("Pulse 1 si realizara otra operacion, sino pulse cualquier numero");
    calculadora = Convert.ToInt32(Console.ReadLine());

    if (calculadora != 1)
    {
        Console.WriteLine("Muchas gracias por usar la calculadora :)");
    }
}


int sumar(int n1, int n2)
{
    return n1+n2;
}

int restar(int n1, int n2)
{
    return n1-n2;
}

int multiplicar(int n1, int n2)
{
    return n1*n2;
}

int dividir(int n1, int n2)
{
    return n1/n2;
}

//Console.WriteLine("Chau V1");