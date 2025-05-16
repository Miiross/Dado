using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    public class Dado
    {
        public int Lados { get; private set; }
        private Random random;

        public Dado(int lados)
        {
            Lados = lados;
            random = new Random();
        }

        public int Jogar()
        {
            return random.Next(1, Lados + 1);
        }

        public int GetLadoOposto(int numero)
        {
            if (Lados == 6)
            {
                if (numero == 1) return 6;
                else if (numero == 2) return 5;
                else if (numero == 3) return 4;
                else if (numero == 4) return 3;
                else if (numero == 5) return 2;
                else if (numero == 6) return 1;
            }
            else if (Lados == 8)
            {
                if (numero == 1) return 8;
                else if (numero == 2) return 7;
                else if (numero == 3) return 6;
                else if (numero == 4) return 5;
                else if (numero == 5) return 4;
                else if (numero == 6) return 3;
                else if (numero == 7) return 2;
                else if (numero == 8) return 1;
            }
            else if (Lados == 10)
            {
                if (numero == 1) return 10;
                else if (numero == 2) return 9;
                else if (numero == 3) return 8;
                else if (numero == 4) return 7;
                else if (numero == 5) return 6;
                else if (numero == 6) return 5;
                else if (numero == 7) return 4;
                else if (numero == 8) return 3;
                else if (numero == 9) return 2;
                else if (numero == 10) return 1;
            }
            else if (Lados == 12)
            {
                if (numero == 1) return 12;
                else if (numero == 2) return 11;
                else if (numero == 3) return 10;
                else if (numero == 4) return 9;
                else if (numero == 5) return 8;
                else if (numero == 6) return 7;
                else if (numero == 7) return 6;
                else if (numero == 8) return 5;
                else if (numero == 9) return 4;
                else if (numero == 10) return 3;
                else if (numero == 11) return 2;
                else if (numero == 12) return 1;
            }
            else if (Lados == 16)
            {
                if (numero == 1) return 16;
                else if (numero == 2) return 15;
                else if (numero == 3) return 14;
                else if (numero == 4) return 13;
                else if (numero == 5) return 12;
                else if (numero == 6) return 11;
                else if (numero == 7) return 10;
                else if (numero == 8) return 9;
                else if (numero == 9) return 8;
                else if (numero == 10) return 7;
                else if (numero == 11) return 6;
                else if (numero == 12) return 5;
                else if (numero == 13) return 4;
                else if (numero == 14) return 3;
                else if (numero == 15) return 2;
                else if (numero == 16) return 1;
            }
            else if (Lados == 20)
            {
                if (numero == 1) return 20;
                else if (numero == 2) return 19;
                else if (numero == 3) return 18;
                else if (numero == 4) return 17;
                else if (numero == 5) return 16;
                else if (numero == 6) return 15;
                else if (numero == 7) return 14;
                else if (numero == 8) return 13;
                else if (numero == 9) return 12;
                else if (numero == 10) return 11;
                else if (numero == 11) return 10;
                else if (numero == 12) return 9;
                else if (numero == 13) return 8;
                else if (numero == 14) return 7;
                else if (numero == 15) return 6;
                else if (numero == 16) return 5;
                else if (numero == 17) return 4;
                else if (numero == 18) return 3;
                else if (numero == 19) return 2;
                else if (numero == 20) return 1;
            }

            return -1; // valor inválido
        }
    }


}

