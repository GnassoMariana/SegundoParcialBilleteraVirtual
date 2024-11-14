using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class Dolar: Moneda
    {
        private decimal valorEnPesos;
        public static Dolar()
        {
            valorEnpesos = 350;
        }
        public Dolar(decimal cantidad) : base(cantidad, codigo, simbolo)
        {

        }

        public virtual Moneda ConvertirA(Type moneda)
        {
            return Cantidad * 350;
        }
    }
}
