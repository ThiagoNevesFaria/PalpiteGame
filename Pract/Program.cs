using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int palpite = 0;
            Random rdm = new Random();
            
            int numeroSecreto = rdm.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
           
            List<string> palpitesDados = new List<string>();
            //Console.ForegroundColor = ConsoleColor.Green;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Inserir palpite:");
                string entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("■■■■■■■ Digita algo ai mane ■■■■■■■");
                    continue;
                }
                
                int.TryParse(entrada, out palpite);


                if (!palpitesDados.Contains(palpite.ToString()))
                {
                    palpitesDados.Add(entrada);
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("▐ Palpite ja foi dado ▐ ");
                    continue;
                }


                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    numeroEncontrado = true;
                    Console.WriteLine("Palpite atual = " + palpite);
                    Console.WriteLine("Parabens !! Numero encontrado em {0} tentativas", tentativas);
                }
                else if (palpite > numeroSecreto)
                {
                    if (tentativasRestantes == 0)
                    {                       
                        Console.WriteLine("Palpite atual = {0}", palpite);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Chances Acabaram");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Palpite atual = " + palpite);
                        Console.WriteLine("Palpite acima !, chances restantes {0}", tentativasRestantes);
                    }
                }
                else if (palpite < numeroSecreto)
                {
                    if (tentativasRestantes == 0)
                    {                      
                        Console.WriteLine("Palpite atual = {0}", palpite);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Chances Acabaram");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Palpite atual = " + palpite);
                        Console.WriteLine("Palpite abaixo !, chances restantes {0}", tentativasRestantes);
                    }

                }
                else if (tentativasRestantes == 0)
                {                   
                    Console.WriteLine("Palpite atual {0}", palpite);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Chances acabaram");
                }

            }
            if (tentativasRestantes == 0 && numeroSecreto != palpite)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("PERDEU MANO");
            }
            
        }       
    }
}

/* TODO List
   Implementar uma lista para armazenar os palpites ja dados/lidos pelo ReadLine XXXXX
 * fazer um metodo para checar se o numero esta perto(quente) ou longe (frio)
 * */