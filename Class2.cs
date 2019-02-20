using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Carta
    {
        string[] cartas = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public string carta;
        public int valor;
        Random aleatorio = new Random();

        public void Generar()
        {
            int indice = aleatorio.Next(0, cartas.Length);
            carta = cartas[indice];

            if (carta == "A") valor = 1;
            else if (carta == "J" || carta == "Q" || carta == "K");
            else valor = int.Parse(carta);
        }


    }
}
