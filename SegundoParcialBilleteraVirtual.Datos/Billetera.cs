using SegundoParcialBilleteraVirtual.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Datos
{
    public class Billetera
    {
        public List<Moneda> Monedas { get; set; }

        public Billetera()
        {
            Monedas = new List<Moneda>();
            
        }
         
        public void Deposito(Moneda moneda)
        {
            if (!Monedas.Contains(typeof(moneda)))
            {
                Monedas.Add(moneda);
            }
            else
            {
                var total;

            }
        }

        public (bool resultado , string mensaje) Retiro(Moneda moneda)
        {
            if(moneda.Cantidad > 0)
            {
                
            }
        }
        


    }
}
