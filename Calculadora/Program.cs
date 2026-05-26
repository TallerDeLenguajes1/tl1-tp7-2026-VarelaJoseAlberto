
using EspacioCalculadora;

Calculadora calc =new Calculadora();

calc.Sumar(10); //dato = 10
System.Console.WriteLine(calc.Resultado);
calc.Sumar(10); //dato = 20
System.Console.WriteLine(calc.Resultado);

calc.Resta(10); //dato = 10
System.Console.WriteLine(calc.Resultado);

calc.Multiplicar(3); //dato 30
System.Console.WriteLine(calc.Resultado);

calc.Dividir(10); //datp = 3
System.Console.WriteLine(calc.Resultado);

calc.Limpiar(); //dato = 0

System.Console.WriteLine(calc.Resultado);