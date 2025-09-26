using System;

class ValidadorContraseña
{
    // Función principal que llama a los validadores individuales
    static bool EsContraseñaValida(string pass)
    {
        return TieneLongitudValida(pass) &&
               TieneMayuscula(pass) &&
               TieneMinuscula(pass) &&
               TieneNumero(pass) &&
               TieneCaracterEspecial(pass);
    }

    // Verifica longitud mínima
    static bool TieneLongitudValida(string pass)
    {
        return pass.Length >= 8;
    }

    // Verifica al menos una letra mayúscula
    static bool TieneMayuscula(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsUpper(c)) return true;
        }
        return false;
    }

    // Verifica al menos una letra minúscula
    static bool TieneMinuscula(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsLower(c)) return true;
        }
        return false;
    }

    // Verifica al menos un número
    static bool TieneNumero(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsDigit(c)) return true;
        }
        return false;
    }

    // Verifica al menos un carácter especial
    static bool TieneCaracterEspecial(string pass)
    {
        string especiales = "!@#$%^&*";
        foreach (char c in pass)
        {
            if (especiales.Contains(c)) return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        string contraseña;

        do
        {
            Console.Write("Ingresa una contraseña segura: ");
            contraseña = Console.ReadLine();

            if (!EsContraseñaValida(contraseña))
            {
                Console.WriteLine("\nContraseña inválida. Debe cumplir todos los requisitos:");
                Console.WriteLine("• Mínimo 8 caracteres");
                Console.WriteLine("• Al menos una mayúscula");
                Console.WriteLine("• Al menos una minúscula");
                Console.WriteLine("• Al menos un número");
                Console.WriteLine("• Al menos un carácter especial (!@#$%^&*)\n");
            }

        } while (!EsContraseñaValida(contraseña));

        Console.WriteLine("Contraseña válida. ¡Bien hecho!");
    }
}
