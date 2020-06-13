using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Algarismo<T>
    {
        public T valorAlgarismo { get; set; }

        public T somarAlgarismos(T valorAlgarismoPirmeiro, T valorAlgarismoSegundo)
        {
            // FONTE: https://stackoverflow.com/questions/8122611/c-sharp-adding-two-generic-values

            dynamic operando1 = valorAlgarismoPirmeiro;
            dynamic operando2 = valorAlgarismoSegundo;
            return operando1 + operando2;
        }
    }
}
