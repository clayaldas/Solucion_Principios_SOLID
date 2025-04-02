using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_2__CORRECT_
{
    /// <summary>
    /// BackEndDeveloper implementa la interfaz IDeveloper.
    /// </summary>
    public class BackEndDeveloper : IDeveloper
    {
        public void Develop()
        {
            Console.WriteLine("El desarrollador back-end está codificando en C #...");
        }
    }
}
