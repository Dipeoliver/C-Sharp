using System.Globalization;

namespace ExercicioAula60
{
   class ContaBancaria
    {
       
        public int NumeroConta { get; private set;}
        public string Nome { get; set; }
        public double Saldo { get; private set; }
       
            public ContaBancaria(string nome, int numeroconta)
        {
            Nome = nome;
            NumeroConta = numeroconta;
            
        }
        public ContaBancaria(string nome, int numeroconta, double depositoinicial): this(nome, numeroconta)
        {
            AdicionarSaldo(depositoinicial);        }

        

        public void AdicionarSaldo(double saldo)
        {
            Saldo += saldo;
        }

        public void SubtrairSaldo(double saldo)
        {
            Saldo -= saldo + 5.00;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
