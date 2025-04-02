namespace Dependency_Inversion_Principle_2__CORRECT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Principio de inversión de la dependencia!");

            Console.WriteLine();

            // Se inyectan las dependencias en tiempo de ejecución
            List<IDeveloper> developers = new List<IDeveloper>
            {
                new FrontEndDeveloper(),  
                new BackEndDeveloper(),
                new MobileDeveloper(),
            };
            
            Project project = new Project(developers);
            project.Build();

            Console.ReadLine();
        }
    }
}
