using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTAO 1
            Console.WriteLine(" QUESTAO 1 ");

            Console.Write("informe um numero de 4 digitos");
            numero = int.Parse(Console.ReadLine());

            x = numero / 1000;
            x = x + 7;

            y = numero / 100;
            y = y % 10;
            y = y + 7;

            w = numero / 10;
            w = w % 10;
            w = w + 7;

            z = numero / 1;
            z = z % 1;
            z = z + 7;

            Console.WriteLine(w);
            Console.WriteLine(z);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();



            // QUESTAO 2
            Console.WriteLine(" QUESTAO 2 ");

            int saldo = 0;

            Console.WriteLine("valor do saldo atual:\n ");
            saldo = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(saldo, 2, 300, 400, 2000);
            Console.WriteLine("o seu  saldo é de:\n");
            Console.WriteLine(cliente.CalcularNovoSaldo());

            cliente.AtualizarSaldo();

            if (cliente.UltrapassouLimite())
            {
                Console.WriteLine("credito Excedido.");
            }
            else
            {
                Console.WriteLine("crédito disponivel.");
            }

            Console.ReadKey();
            Console.Clear();


            // QUESTAO 3
            Console.WriteLine(" QUESTAO 3 ");

            bool par = true;
            bool impar = false;
            int numero;

            Console.WriteLine("informe um valor de entre 0 a 10");

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(par);
            }

            else (numero % 2 != 0);
            {
                Console.WriteLine(impar);
            }

      
            // QUESTAO 4
            Console.WriteLine(" QUESTAO 4 ");

            int a = 0, b = 0, c = 0;

            Console.Write("\nqual e o seu trinagulo ?");

            Console.WriteLine("valo1r");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("valor2");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("valor3");
            c = Convert.ToInt32(Console.ReadLine());


            if (a == b && a == c)  //laods iguais 
            {
                Console.WriteLine("\ntriangulo equilátero\n");
            }

            else if (a == b && b == a && c != a && c != b)//dois lados iguais 
            {
                Console.WriteLine("\ntriangulo  isósceles\n");
            }

            else if (a != b && a != c && b != a && b != c && c != a) ; //lados diferentes 
            {
                Console.WriteLine("\ntriangulo escaleno\n");
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();

            // QUESTAO 5 
            Console.WriteLine(" QUESTAO 5 ");

            int verifica = 0;

            Console.WriteLine("Digite uma letra \n");

            var letra = Console.ReadLine().ToArray();

            string[] vogais = new string[] { "a", "A", "e", "E", "i", "I", "o", "O", "u", "U" };


            if (letra.Length == 1)
            {
                for (int i = 0; i < vogais.Length; i++)
                    {
                        if (letra[0].ToString() == vogais[i])
                            {
                                verifica = 1;
                            }
                    }

                if (verifica == 1)
                    {
                        Console.WriteLine("\n\tE UMA VOGAL.");
                    }

                else
                    {
                        Console.WriteLine("\n\tE UMA CONSOANTE ");
                    }
                    
            }
            else
                {
                    Console.WriteLine("NAO E PERMITIDO ");
                }

            Console.ReadKey();
            Console.Clear();

            // QUESTAO 6 
            Console.WriteLine(" QUESTAO 6 ");

            int n;
            int p;
            int r;
            r = 0;

            Console.WriteLine("\nDIGITE UM NUMERO\n");
            n = int.Parse(Console.ReadLine());

            for (p = 1; p <= n; p++)
            {
                if (n % p == 0)
                {
                    r = r + 1;
                }
            }

            if (r > 2)
            {
                Console.WriteLine("{0} E PRIMO" ,n);
            }

            else 
            {
                Console.WriteLine("{0} NAO E PRIMO" ,n);
            }

            Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
