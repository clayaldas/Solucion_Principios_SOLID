namespace SOLID__CORRECT_
{
    // 2. Aplicamos el principio: OCP.
    //    Ahora podemos agregar mas formatos para los reportes sin modificar el código existente.
    public class ReportGenerator
    {
        private readonly IReport _report;
        public ReportGenerator(IReport report)
        {
            _report = report;
        }

        public void GenerateReport() {
            _report.Generate();
        }
    }
}
