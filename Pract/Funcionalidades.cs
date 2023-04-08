using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Funcionalidades
    {
        static string entradaPalpite;
        public void Inicio()
        {
            Console.WriteLine("Comecou !");
        }
        public void Armazenar()
        {
            List<string> palpitesDados = new List<string>();
            entradaPalpite = Console.ReadLine();
            int i = 0;
            while (i < 5)
            {
                string entradaPalpite = Console.ReadLine();
                palpitesDados.Add(entradaPalpite);
                i++;
                Console.WriteLine(entradaPalpite);
            }

        }
        public void PalpiteUsado()
        {
            
        }
        
    }
}
