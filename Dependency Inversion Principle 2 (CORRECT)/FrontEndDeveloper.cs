using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_2__CORRECT_
{
    /// <summary>
    /// FrontEndDeveloper implementa la interfaz IDeveloper.
    /// </summary>
    public class FrontEndDeveloper : IDeveloper
    {
        public void Develop()
        {
            Console.WriteLine("El desarrollador front-end está codificando en React...");
        }
    }
}
