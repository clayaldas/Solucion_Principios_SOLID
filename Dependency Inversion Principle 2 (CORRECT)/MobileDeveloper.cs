using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_2__CORRECT_
{
    /// <summary>
    /// Nueva implementación
    /// </summary>
    public class MobileDeveloper : IDeveloper
    {
        public void Develop()
        {
            Console.WriteLine("El desarrollador móvil está codificando en Flutter...");
        }
    }
}
