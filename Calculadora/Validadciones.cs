namespace EspacioCalculadora;

public static class Validaciones
{
    public static double LeerNumero(string texto)
    {
        while (true)
        {
            Console.Write(texto);
            string? input = Console.ReadLine();

            bool ok = double.TryParse(input, out double numero);

            if (ok)
                return numero;

            Console.WriteLine("Error: ingrese un numero valido.");
        }
    }

    public static string ContinuarOperando(string texto)
    {
        string? continuar;
        while (true)
        {
            Console.Write($"¿Desea seguir {texto}? (s/n): ");
            continuar = Console.ReadLine()?.ToLower();

            if (continuar == "s" || continuar == "n")
                return continuar;

            Console.WriteLine("Opción inválida. Solo se permite s o n.");
        }

    }
}