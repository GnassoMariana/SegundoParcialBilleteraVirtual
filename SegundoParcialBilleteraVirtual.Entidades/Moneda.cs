using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialBilleteraVirtual.Entidades
{
    public  class Moneda
    {
        private decimal cantidad;
        private string codigo;
        private string simbolo;

       public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (cantidad is not  null && cantidad>0)
                {
                    return cantidad = value;
                }
                else
                {
                    return throw new ArgumentException("La cantidad debe ser mayor a cero");
                }
            }
        }
        public string Codigo
       {
            get {  return codigo; }
            set 
            {
                if(codigo is not  null)
                {
                    return codigo = value;
                }
                else
                {
                    return throw new ArgumentException("Se debe ingresar un codigo");
                }
            }
       }
       public string Simbolo
        {
            get { return simbolo; }
            set
            {
                if (simbolo is not  null)
                {
                    return simbolo = value;
                }
                else
                {
                    return throw new ArgumentException("Se debe ingresar un simbolo");
                }
            }
        }
        protected Moneda()
        {
            
        }
        public Moneda(decimal cantidad, string codigo, string simbolo)
        {
            Cantidad = cantidad;
            Codigo = codigo;
            Simbolo = simbolo;
        }

        public override string ToString()
        {
            return $"Codigo: {Codigo}--- Simbolo {Simbolo}--- Cantidad{Cantidad}";
        }

        public abstract Moneda CanvertirA(Type moneda)
        {

        }



        
    }
}
