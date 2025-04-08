namespace SOLID__BAD_
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Principios SOLID!");
      Console.WriteLine();

      Report report = new Report();

      report.GenerateReport("PDF");
      report.SaveToFile();
      report.SendEmail();
    }
  }

  
  class Report
  {
    public void GenerateReport(string reportType)
    {
     
       // 1: SRP
      if (reportType == "PDF")
      {
        Console.WriteLine("Generando reporte en PDF...");
      }
      else if (reportType == "Excel")
      {
        Console.WriteLine("Generando reporte en Excel..");
      }
      else
      {
        Console.WriteLine("Tipo de reporte no válido");
      }
    }

    // 3: ISP
    public void SaveToFile()
    {
      Console.WriteLine("Guardando reporte en un archivo...");
    }

    public void SendEmail()
    {
      Console.WriteLine("Enviando reporte via email...");
    }
  }
}
