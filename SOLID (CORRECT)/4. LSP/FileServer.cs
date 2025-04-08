namespace SOLID__CORRECT_
{
    // 4. Aplicamos LSP: Cada clase derivada (heradada) sigue funcionando sin romper el 
    //    el comportamiento esperado.
    public class FileServer : IFileServer
    {
        public void SaveToFile()
        {
            Console.WriteLine("Guardando a un archivo...");
        }
    }
}
