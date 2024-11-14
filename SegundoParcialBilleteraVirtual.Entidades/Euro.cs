using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Datos
{
    public class Euro:Moneda
    {
        private decimal valorEnDolares;
        private decimal valorEnPesos;
        public static Euro()
        {
            valorEnDolares = 0.94;
            valorEnPesos = 370;
        }
        public Euro(decimal cantidad) : base(cantidad, codigo, simbolo)
        {

        }

        public virtual Moneda ConvertirA(Type moneda)
        {
            switch (moneda)
            {
                case typeof(Dolar):
                    return Cantidad * 0.94;
                    break;
                case typeof(PesoArgentino):
                    return Cantidad * 370;
                    break;

                default:
                    return "Se debe ingresar tipo de moneda a convertir";
                    break;
            }
        }
    }
}
