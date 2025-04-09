namespace fisei.uta.edu.ec.utils
{
    public class Matemathics
    {
        /// <summary>
        /// Permite sumar 2 números
        /// </summary>
        /// <param name="a">Primer sumando</param>
        /// <param name="b">Segundo sumando</param>
        /// <returns>Retorna la suma de los números</returns>
        public long Add(int a, int b)
        {
            return a + b;
        }

        public long Substract(int a, int b)
        { 
            return a - b;
        }

        public static long Pow(int _base, int exponent)
        {
            long result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= _base;
            }

            return result;
        }
    }
}
