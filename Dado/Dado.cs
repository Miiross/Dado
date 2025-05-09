using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        private Random random;

        public Dado()
        {
            random = new Random();
        }

        public int Jogar()
        {
            return random.Next(1, 7);
        }

        public string GetImagem(int numero)
        {
            return $"dado{numero}.png";
        }
    }

}

