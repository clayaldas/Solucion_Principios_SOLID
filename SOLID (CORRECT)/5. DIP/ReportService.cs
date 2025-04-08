namespace SOLID__CORRECT_
{
    public class ReportService
    {
        private readonly IFileServer _fileServer;
        private readonly IEmailSender _emailSender;

        public ReportService(IFileServer fileServer, IEmailSender emailSender)
        {
            _fileServer = fileServer;
            _emailSender = emailSender;
        }

        public void ProcessReport(IReport report)
        {
            ReportGenerator generator = new ReportGenerator(report);

            generator.GenerateReport();
            _fileServer.SaveToFile();
            _emailSender.SendEmail();
        }

    }
}
