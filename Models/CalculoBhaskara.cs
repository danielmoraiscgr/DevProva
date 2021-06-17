using System;
namespace DevProva
{
    public class CalculoBhaskara
    {
        public double ResultadoCalculoBhaskara(int a, int b, int c)
        {

            double delta = (b * b) - (4 * a * c);

            double raiz = Math.Sqrt(delta);           

            if (delta > 0)
            {
                var x1 = ((-(b)) + raiz) / (2 * a);

                var x2 = ((-(b)) - raiz) / (2 * a);

                return Math.Max(x1, x2);
            }
            else if (delta == 0)
            {
                return 0;
            }
            else
                return -1;            

        }
    }
}
