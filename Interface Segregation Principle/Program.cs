namespace Interface_Segregation_Principle
{
  
  // Esta interfaz es demasiado general
  public interface IWorker
  {
    void Work();
    void Eat();
  }
  public class Human : IWorker
  {
    public void Work()
    {
      Console.WriteLine("Un humano trabaja...");
    }

    public void Eat()
    {
      Console.WriteLine("Un humano come...");
    }
  }

  public class Robot : IWorker
  {
    public void Work()
    {
      Console.WriteLine("Un robot trabaja...");
    }

    public void Eat()
    {
      // ¡Un robot no necesita comer!
      throw new NotImplementedException();
    }
  }

  class Program
  {
    static void Main()
    {
      // Crear instancias
      IWorker robot = new Robot();
      IWorker human = new Human();      

      // Ejecutar métodos
      robot.Work();
      //robot.Eat();
      human.Work();
      human.Eat();

      // Esperar entrada para mantener la consola abierta
      Console.ReadLine();
    }
  }

}
