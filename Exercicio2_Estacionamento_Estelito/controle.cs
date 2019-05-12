using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Estacionamento_Estelito
{
    class controle
    {

        private int TotalVagas, QtdeVeiculos;

        public int QtdeVeiculos1
        {
            get
            {
                return QtdeVeiculos;
            }

            set
            {
                QtdeVeiculos = value;
            }
        }

        public int TotalVagas1
        {
            get
            {
                return TotalVagas;

            }

            set
            {
                TotalVagas = value;
            }
        }


        public int AddVeiculos()
        { 

                

            if (QtdeVeiculos < TotalVagas)
            {
                return QtdeVeiculos++;
            }

            return QtdeVeiculos;

        }

        public int RemoveVeiculos()
        {

            if (QtdeVeiculos > 0)
            {
                return QtdeVeiculos--;
            }

            return QtdeVeiculos;
        

        }
  

    } 
}
