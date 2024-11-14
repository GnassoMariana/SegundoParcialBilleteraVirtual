using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class Yuanes: Moneda
    {
        private decimal valorEnPesos;
        private decimal valorEnDolares;
        private decimal valorEnEuros;
        public static Yuanes()
        {
            valorEnDolares = 7.1;
            valorEnPesos = 50;
        }
        public Yuanes(decimal cantidad) : base(cantidad, codigo, simbolo)
        {

        }

        public virtual Moneda ConvertirA(Type moneda)
        {
            switch (moneda)
            {
                case typeof(Dolar):
                    return Cantidad / 7.1;
                    break;
                case typeof(PesoArgentino):
                    return Cantidad *50;
                    break;
               

                default:
                    return "Se debe ingresar tipo de moneda a convertir";
                    break;
            }
        }
    }
}
