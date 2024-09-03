using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alarme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alarme alarme = new Alarme();
            Alarme alarme;
            string resposta = "S";
            while (resposta != "N")
            {
                Console.Clear();
                Console.WriteLine("Alarme");
                Console.Write("Informe a duração do Alarme: ");
                int tempo = Convert.ToInt32(Console.ReadLine());// usuario informa o tempo
               // alarme.Tempo = tempo; // objeto recebe o tempo


               
                Console.Write("Informe o efeito sonoro 1 ou 2: ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());
                //alarme.EfeitoSonoro = efeitoSonoro;
                alarme  = new Alarme(tempo, efeitoSonoro);




                alarme.Iniciar();// objeto chama a funcao
                Console.WriteLine("Deseja executar o alarme novamnete S/N: ");
                resposta = Console.ReadLine().ToUpper();

            }

          
        }
    }
}

