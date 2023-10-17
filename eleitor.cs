using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            Console.WriteLine("aplicação que diz se você tem que votar");
            Console.WriteLine("qual o seu nome? ");
            nome=Console.ReadLine();
            Console.WriteLine("qual sua idade? ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade <16)
            {
                Console.WriteLine( " {0} Você não tem idade para votar", nome);
            } 
           else
            {
                if ((idade>15 && idade <18) || (idade>65))
                {
                    Console.WriteLine(" {0} Você é um eleitor facultativo", nome);
                }
                else
                {
                    Console.WriteLine(" {0} seu voto é obrigatório", nome);
                }
            }
            Console.ReadKey();
        }
    }
}
