using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public class PesoArgentino: Moneda
    {
        private decimal valorEnDolares;
        private decimal valorEnEuros;
        private decimal valorEnYuanes;
        public static PesoArgentino()
        {
            valorEnDolares = 350;
            valorEnEuros = 370;
            valorEnYuanes = 50;
        }
        public  PesoArgentino(decimal cantidad): base(cantidad, codigo, simbolo)
        {
            
        }

        public virtual Moneda ConvertirA(Type moneda)
        {
            switch (moneda)
            {
                case typeof(Dolar): 
                    return Cantidad / 350;
                    break;
                case typeof(Euro):
                    return Cantidad / 370;
                    break;
                case typeof(Yuanes):
                    return Candidad / 50;
                    break;

                default:
                    return "Se debe ingresar tipo de moneda a convertir";
                    break;
            }
        }
    }
}
