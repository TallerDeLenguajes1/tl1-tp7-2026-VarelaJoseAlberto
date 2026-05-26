
using EspacioCalculadora;

Calculadora calc = new Calculadora();

int opcion;
do
{
    Console.Clear();

    Console.WriteLine("=== CALCULADORA ===");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("0 - Salir");

    Console.Write("Opcion: ");
    string? input = Console.ReadLine();

    bool opcionOK = int.TryParse(input, out opcion);

    if (!opcionOK)
    {
        Console.WriteLine("Error: la opcion solo puede ser numerica");
        Console.ReadKey();
        continue;
    }

    calc.Limpiar();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("--- SUMA ---");
            string? continuar = "s";

            while (continuar == "s")
            {
                double numero = Validaciones.LeerNumero("Ingrese el numero: ");

                calc.Sumar(numero);

                Console.WriteLine("Resultado actual: " + calc.Resultado);

                continuar = Validaciones.ContinuarOperando("Sumando");
            }

            break;

        case 2:
            Console.WriteLine("--- RESTA ---");
            string? continuar1 = "s";

            while (continuar1 == "s")
            {
                double numero = Validaciones.LeerNumero("Ingrese el numero: ");

                calc.Restar(numero);

                Console.WriteLine("Resultado actual: " + calc.Resultado);

                continuar1 = Validaciones.ContinuarOperando("Restando");
            }
            break;

        case 3:
            Console.WriteLine("--- MULTIPLICACION ---");
            string? continuar2 = "s";

            while (continuar2 == "s")
            {
                double numero = Validaciones.LeerNumero("Ingrese el numero: ");

                calc.Multiplicar(numero);

                Console.WriteLine("Resultado actual: " + calc.Resultado);

                continuar2 = Validaciones.ContinuarOperando("Multiplicando");
            }
            break;

        case 4:
            Console.WriteLine("--- DIVISION ---");
            string? continuar3 = "s";

            while (continuar3 == "s")
            {
                double numero = Validaciones.LeerNumero("Ingrese el numero: ");

                if (numero == 0)
                {
                    Console.WriteLine("Error: no se puede dividir por cero");
                    Console.ReadKey();
                    break;
                }

                calc.Dividir(numero);

                Console.WriteLine("Resultado actual: " + calc.Resultado);

                continuar3 = Validaciones.ContinuarOperando("Sumando");
            }
            break;

        case 5:
            Console.WriteLine("--- LIMPIAR ---");
            calc.Limpiar();
            Console.WriteLine("Resultado: " + calc.Resultado);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            break;

        case 0:
            Console.WriteLine("Saliendo...");
            return;

        default:
            Console.WriteLine("Opcion invalida... Presione una tecla para continuar...");
            Console.ReadKey();
            continue;

    }

} while (opcion != 0);
