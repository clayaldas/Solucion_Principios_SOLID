using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_2__CORRECT_
{
    /// <summary>
    /// Clase de alto nivel.
    /// La clase Project ahora depende de la abstracción IDeveloper.
    /// </summary>
    public class Project
    {
        private readonly List<IDeveloper> _developers;
        public Project(List<IDeveloper> developers)
        {
            _developers = developers;
        }

        public void Build()
        {
            foreach (var developer in _developers)
            {
                developer.Develop();
            }
        }
    }
}
