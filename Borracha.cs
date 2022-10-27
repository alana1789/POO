using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borracha
    {
        private string marca;
        private int percentualApagar;


        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int QuantidadeFolha
        {
            get { return percentualApagar; }
            set { percentualApagar = value; }
        }

        public Borracha(string _marca)
        {
            marca = _marca;
            percentualApagar = 100;

        }

        public void Apagar()
        {
            if (percentualApagar > 1)
            {
                QuantidadeFolha -= 5;
            }
        }
    }
}