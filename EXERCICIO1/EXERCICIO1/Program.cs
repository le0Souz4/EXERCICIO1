using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular media final \r\n");
            Console.WriteLine("Insira nome do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Primeira nota");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segunda nota");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota do trabalho");
            float t1 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + t1) / 3;
            if (media >= 8.5)
            {
                Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: A");
            }
            else if (media >= 7 && media >= 8.4)
            {
                Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: B");

            }
            else if (media >= 6 && media <= 6.9)
            {
                Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: C");

            }
            else if (media >= 0.1 && media <= 5.9)
            {
                Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: D");

            }
            else if (media == 0)
            {
                Console.WriteLine("Nome:" + nome + " " + "Media final:" + media + " " + "Conceito: E");

            }
            Console.ReadKey();
        }
    }
}
