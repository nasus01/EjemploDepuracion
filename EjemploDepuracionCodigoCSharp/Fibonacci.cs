using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDepuracionCodigoCSharp
{
    public class Fibonacci : Funciones
    {
        public List<int> rellenar()
        {
            int f1 = 0, f2 = 1;
            
            List<int> valores = new List<int>();
            for (int i = 0; i < this.getNumero(); i++)
            {
                int temp = f1;

                valores.Add(f1);
                f1 = f2;
                f2 = temp + f2;
            }
            return valores;
            //int i = 0;
            //while (i <= this.getNumero())
            //{
            //    int temp = f1;
            //    valores.Add(f1);
            //    f1 = f2;
            //    f2 = temp + f2;
            //    i++;
            //}
            //return valores;

        }
    }
}