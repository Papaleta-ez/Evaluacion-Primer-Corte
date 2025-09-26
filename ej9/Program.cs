﻿using System;

class ValidadorFecha
{
    // Variable global que indica si la fecha es válida
    static bool fechaValida = false;

    // Función para validar el mes
    static bool MesValido(int mes)
    {
        return mes >= 1 && mes <= 12;
    }

    // Función para determinar si el año es bisiesto
    static bool EsBisiesto(int año)
    {
        return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
    }

    // Función para validar el día según el mes y si el año es bisiesto
    static bool DiaValido(int dia, int mes, int año)
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (EsBisiesto(año)) diasPorMes[1] = 29; // febrero

        return dia >= 1 && dia <= diasPorMes[mes - 1];
    }

    // Función principal para validar la fecha
    static void ValidarFecha()
    {
        Console.Write("Ingresa el día: ");
        string entradaDia = Console.ReadLine()!;

        Console.Write("Ingresa el mes: ");
        string entradaMes = Console.ReadLine()!;

        Console.Write("Ingresa el año: ");
        string entradaAño = Console.ReadLine()!;

        if (int.TryParse(entradaDia, out int dia) &&
            int.TryParse(entradaMes, out int mes) &&
            int.TryParse(entradaAño, out int año))
        {
            bool mesOk = MesValido(mes);
            bool diaOk = mesOk && DiaValido(dia, mes, año);
            bool bisiesto = EsBisiesto(año);

            fechaValida = mesOk && diaOk;

            Console.WriteLine($"\n Año bisiesto: {(bisiesto ? "Sí" : "No")}");
            Console.WriteLine($"Fecha ingresada: {dia}/{mes}/{año}");

            if (fechaValida)
                Console.WriteLine("La fecha es válida.");
            else
                Console.WriteLine("La fecha es inválida.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debes ingresar números enteros.");
        }
    }

    static void Main(string[] args)
    {
        ValidarFecha(); // Llamada al validador
    }
}