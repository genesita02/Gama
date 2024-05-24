// See https://aka.ms/new-console-template for more information
Console.WriteLine("par o impar");

    {
        // Solicitar al usuario que ingrese un número
        Console.Write("Ingrese un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Determinar si el número es par o impar
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} es un número par.");
        }
        else
        {
            Console.WriteLine($"{numero} es un número impar.");
        }
    }


