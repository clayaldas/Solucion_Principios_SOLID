namespace Interface_Segregation_Principle__CORRECT_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias
            //IWorkable robot = new Robot();
            //IWorkable human = new Human();
            //IEatable humanEater = new Human();

            Robot robot = new Robot();
            Human human = new Human();
            // Ejecutar lo métodos
            robot.Work();
            human.Work();
            //humanEater.Eat();
            human.Eat();

            Console.ReadLine();
        }
    }
}
