namespace Dependency_Inversion_Principle_2__BAD_
{ 
  // Módulos de alto nivel dependen directamente de módulos de bajo nivel
  public class FrontEndDeveloper
  {
    public void Develop()
    {
      Console.WriteLine("El desarrollador front-end está codificando en React...");
    }
  }

  public class BackEndDeveloper
  {
    public void Develop()
    {
      Console.WriteLine("El desarrollador back-end está codificando en C #...");
    }
  }

  // Clase de alto nivel
  public class Project
  {
    private readonly FrontEndDeveloper _frontend;
    private readonly BackEndDeveloper _backend;

    public Project()
    {
      _frontend = new FrontEndDeveloper();
      _backend = new BackEndDeveloper();
    }

    public void Develop()
    {
      _frontend.Develop();
      _backend.Develop();
    }
  }

  class Program
  {
    static void Main()
    {
      Project project = new Project();
      project.Develop();

      Console.ReadLine();
    }
  }
  
}
