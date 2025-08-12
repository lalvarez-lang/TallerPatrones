using BuilderReport.Reports;

class Program
{
    static void Main()
    {
        var reporte = ReportePdfBuilder.Nuevo()
            .ObligatorioConPortada("Banco La felicidad", new byte[0])
            .ConGraficos(new[] { "Inversión", "Ahorro" })
            .ConTablaMovimientos(new[] { "Depósito $100.000", "Retiro $50.000" })
            .ConAnalisisTendencias("El ahorro mensual promedio aumento un 8% respecto al semestre anterior, con un patron de crecimiento estable.")
            .ConPieDePagina("Asesor: Alix Diaz")
            .Build();

        Console.WriteLine($"Reporte generado para: {reporte.Cliente}");
        Console.WriteLine($"Secciones: {string.Join(", ", reporte.Secciones.Select(s => s.Nombre))}");
    }
}