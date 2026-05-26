using SisPersonal;
Empleado[] empleados = new Empleado[3];

//empleado 1
empleados[0] = new Empleado
{
    Nombre = "Jose",
    Apellido = "Varela",
    FechaNacimiento = new DateTime(1998, 7, 13),
    FechaIngreso = new DateTime(2016, 1, 1),
    EstadoCivil = 'S',
    SueldoBasico = 650000,
    Cargo = Cargo.Ingeniero
};

//empleado 2

empleados[1] = new Empleado
{
    Nombre = "Miguel",
    Apellido = "Varela",
    FechaNacimiento = new DateTime(1969, 5, 17),
    FechaIngreso = new DateTime(1990, 3, 15),
    EstadoCivil = 'C',
    SueldoBasico = 500000,
    Cargo = Cargo.Especialista
};

//empleado 3
empleados[2] = new Empleado
{
    Nombre = "Maria",
    Apellido = "Varela",
    FechaNacimiento = new DateTime(1995, 5, 10),
    FechaIngreso = new DateTime(2020, 6, 10),
    EstadoCivil = 'S',
    SueldoBasico = 800000,
    Cargo = Cargo.Investigador
};

double totalSueldos = 0;

foreach (var emp in empleados)
{
    totalSueldos += emp.CalcularSalario();
}

Console.WriteLine("Total dueldo: " + totalSueldos);


Empleado proximo = empleados[0];

foreach (var emp in empleados)
{
    if (emp.AñosParaJubilarse() < proximo.AñosParaJubilarse())
    {
        proximo = emp;
    }
}

Console.WriteLine("\nEmleado proximo a jubilarse:");
Console.WriteLine(proximo.Nombre + " " + proximo.Apellido);
Console.WriteLine("Edad: " + proximo.ObtenerEdad());
Console.WriteLine("Antigüedad: " + proximo.ObtenerAntiguedad());
Console.WriteLine("Años para jubilarse: " + proximo.AñosParaJubilarse());
Console.WriteLine("Salario: " + proximo.CalcularSalario());