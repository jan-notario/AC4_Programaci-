using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Activitat 1

        int total = 0;
        int numero = 0;
        for (int i = 1; i <= 3; i++)

        {
            Console.WriteLine("Dame una nota");
            numero = Convert.ToInt32(Console.ReadLine());
            total = total + numero;
        }

        total = total / 3;

        if (total >= 5)
        {
            System.Console.WriteLine("APROVAT!");
        }
        else
        {
            System.Console.WriteLine("Suspes..");
        }

        System.Console.WriteLine("Fi del programa");

        //Activitat 2

        int numero2 = 1;
        int contadorPares = 0;
        int contadorImpares = 0;

        while (numero2 != 0)
        {
            System.Console.WriteLine("Dame un numero (0 para finalizar)");
            numero2 = Convert.ToInt32(Console.ReadLine());
            if (numero2 != 0)
            {
                if (numero2 % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }
            }
        }

        System.Console.WriteLine("Hay un total de {0} numeros pares y {1} impares.", contadorPares, contadorImpares);
        System.Console.WriteLine("Fin del programa");

        //Actividad 3 

        int numero3 = 0;
        int numero4 = 0;
        int operador = 0;
        string otra = "si";

        System.Console.WriteLine("Dame un numero");
        numero3 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Dame otro numero");
        numero4 = Convert.ToInt32(Console.ReadLine());

        while (otra == "si")
        {
            while (operador <= 0 || operador >= 5)
            {
                System.Console.WriteLine("Que operación quieres utilizar (1- suma, 2-resta, 3 - multiplicación, 4 - división)");
                operador = Convert.ToInt32(Console.ReadLine());

                switch (operador)
                {
                    case 1:
                        numero3 = numero3 + numero4;
                        System.Console.WriteLine("La suma entre ambos numeros es de {0}.", numero3);
                        break;
                    case 2:
                        numero3 = numero3 - numero4;
                        System.Console.WriteLine("La resta entre ambos numeros es de {0}.", numero3);
                        break;
                    case 3:
                        numero3 = numero3 * numero4;
                        System.Console.WriteLine("La multiplicación entre ambos numeros es de {0}.", numero3);
                        break;
                    case 4:
                        numero3 = numero3 / numero4;
                        System.Console.WriteLine("La división entre ambos numeros es de {0}.", numero3);
                        break;

                    default:
                        System.Console.WriteLine("Este numero es incorrecto");
                        break;
                }
            }

            System.Console.WriteLine("quieres añadir otro numero?");
            otra = Console.ReadLine();

            if (otra == "si")
            {
                System.Console.WriteLine("Dame otro numero: ");
                numero4 = Convert.ToInt32(Console.ReadLine());
                operador = 0;
            }
        }

        System.Console.WriteLine("Programa finalizado");

        //Actividad 4

        int dni = 0;
        int divisor = 0;
        int letra = 0;

        while (letra != 3)
        {
            System.Console.WriteLine("Dame un numero dni: ");

            dni = Convert.ToInt32(Console.ReadLine());
            divisor = dni / 23;
            letra = dni - (divisor * 23);
        }
        System.Console.WriteLine("La letra del documento es A");
        System.Console.WriteLine("Fin del programa.");

        //Actividad 5

        int altura = 15;

        for (int i = 1; i <= altura; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Actividad 6


        for (int a = 15; a >= 1; a--)
        {
            for (int b = 1; b <= a; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}