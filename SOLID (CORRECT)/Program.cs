using SOLID__CORRECT_._1._SRP;

namespace SOLID__CORRECT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRINCIPIOS SOLID!");
            Console.WriteLine();

            //IReport report = new PDFReport();
            IReport report = new ExcelReport();
            //ExcelReport report = new ExcelReport();

            IFileServer fileServer = new FileServer();
            IEmailSender emailSender = new EmailSender();

            ReportService reportService = new ReportService(fileServer, emailSender);
            reportService.ProcessReport(report);

        }
    }
}
