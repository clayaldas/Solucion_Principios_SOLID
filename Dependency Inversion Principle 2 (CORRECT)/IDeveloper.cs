using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_2__CORRECT_
{
    /// <summary>
    /// Se crea una abstracción para evitar las dependencias directas.
    /// </summary>
    public interface IDeveloper
    {
        void Develop();
    }   
}
