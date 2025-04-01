namespace Interface_Segregation_Principle__CORRECT_
{
    public class Human : IWorkable, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Un humano come...");
        }

        public void Work()
        {
            Console.WriteLine("Un humano trabaja...");
        }
    }
}
