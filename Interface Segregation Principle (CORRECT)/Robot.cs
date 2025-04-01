namespace Interface_Segregation_Principle__CORRECT_
{
    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Un robot trabaja...");
        }
    }
}
