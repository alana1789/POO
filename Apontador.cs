using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Apontador
    {
        private string marca;
        private int percentualLamina;


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int PercentualLamina
        {
            get { return percentualLamina; }
            set { percentualLamina = value; }
        }

        public Apontador(string _marca)
        {
            marca = _marca;
            percentualLamina = 100;

        }

        public void Apontar(string _apontar)
        {
            if (PercentualLamina > 10)
            {
                Console.WriteLine("O apontador está funcionando");
                return;
            }
            else
            {
                Console.WriteLine("O apontador não está funcionando");
                return;
            }

            Console.WriteLine(_apontar);
            GastarLamina();
        }

        private void GastarLamina()
        {
            percentualLamina -= 10;
        }

    }
    
}