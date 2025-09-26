﻿using System;

class Capicua
{
    // Variable global que almacena el número original
    static int numeroOriginal;

    // Función que invierte el número usando operadores matemáticos
    static int InvertirNumero(int numero)
    {
        int invertido = 0;

        while (numero > 0)
        {
            int digito = numero % 10;              // Extrae el último dígito
            invertido = invertido * 10 + digito;   // Lo agrega al número invertido
            numero /= 10;                          // Elimina el último dígito
        }

        return invertido;
    }

    // Función que determina si el número es capicúa
    static bool EsCapicua()
    {
        int numeroInvertido = InvertirNumero(numeroOriginal);
        return numeroOriginal == numeroInvertido;
    }
}
 static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out numeroOriginal) && numeroOriginal > 0)
        {
            if (EsCapicua())
            {
                Console.WriteLine($"El número {numeroOriginal} es capicúa.");
            }
            else
            {
                Console.WriteLine($"El número {numeroOriginal} no es capicúa.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debes ingresar un número entero positivo.");
        }
    }
