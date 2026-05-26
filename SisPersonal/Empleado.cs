namespace SisPersonal;

public class Empleado
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public char EstadoCivil { get; set; }

    public DateTime FechaIngreso { get; set; }

    public double SueldoBasico { get; set; }

    public Cargo Cargo { get; set; }

    public int ObtenerEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public int ObtenerAntiguedad()
    {
        return DateTime.Now.Year - FechaIngreso.Year;
    }


    public int AñosParaJubilarse()
    {
        return 65 - ObtenerEdad();
    }

    public double CalcularSalario()
    {
        double adicional = 0;

        int antiguedad = ObtenerAntiguedad();

        // antigüedad
        if (antiguedad <= 20)
            adicional += SueldoBasico * (antiguedad * 0.01);
        else
            adicional += SueldoBasico * 0.25;

        // cargo
        if (Cargo == Cargo.Ingeniero || Cargo == Cargo.Especialista)
            adicional *= 1.5;

        // estado civil
        if (EstadoCivil == 'C')
            adicional += 150000;

        return SueldoBasico + adicional;
    }



}
