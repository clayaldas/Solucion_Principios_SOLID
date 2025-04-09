using SOLID__CORRECT_._1._SRP;
using fisei.uta.edu.ec.utils;
using fisei.uta.edu.ec.utils._1._SRP;

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

            Matemathics matemathics = new Matemathics();
            
            Console.WriteLine("Sumar: " + matemathics.Add(10, 10));
            Console.WriteLine("Restar:" + matemathics.Substract(100, 20));
            //Console.WriteLine("Potencia: " + Matemathics.Pow(_base: 2, exponent: 10));
            Console.WriteLine("Potencia: " + Matemathics.Pow(10, 2));
            Console.WriteLine("Potencia: " + Matemathics.Pow(exponent:10,_base: 2));
            //Test test = new Test();
        }
    }
}
