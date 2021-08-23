using System;
using System.Globalization;
namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o nome das variaveis");

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();
            //string c = Console.ReadLine();

            //Console.WriteLine($"Você digitou na variavel frase: {frase}, na variavel x: {x}");

            //string [] vet = Console.ReadLine().Split(" ");        
            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.Write(vet[i]);
            //    Console.Write(" ");
            //}
            //--------------------------------------------------------------------
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine(n1);
            //int n2 = Convert.ToInt16(Console.ReadLine());
            //---------------------------------------------------------------------
            //Console.WriteLine("Entre com o seu nome completo:");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem a sua casa?");
            //int quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço do produto:");
            //double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre seu útimo nome, idade e altura(mesma linha):");
            //string[] vet = Console.ReadLine().Split(" ");
            //for (int i = 0; i < vet.Length; i++)
            //{
            //    Console.Write(vet[i]);
            //    Console.Write(" ");
            //}
            //------------------------------------------------------------
            //Console.WriteLine("Digite os codigo da peça");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantiade de peça");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da peça");
            //double c = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite os codigo da peça2");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantiade de peça2");
            //int b1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da peça2");
            //double c1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"O valor total pago será de: R$ {((c*b) + (c1*b1)).ToString("F2")}");

            //-------------------------------------------------------------------


            //string[] valores = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);

            //int duracao;
            //if (horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            // ---------------------------------------------------------------------

            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(valor);
            if (valor > 0 && valor <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }else if (valor > 0 && valor < 50)
            {
                Console.WriteLine("Intervalo [25,50]");

            }else if (valor > 0 && valor < 75)
            {
                Console.WriteLine("Intervalo [50,75]");
            }else if (valor > 0 && valor <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");               
            }
            else Console.WriteLine("Valor fora de intervalo");        

        }

    }
}
