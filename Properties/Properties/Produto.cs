using System.Globalization;


namespace Sexto
{
    class Produto
    {
        // atributos privados
        private string _nome;
        //--------------------------
        // AUTO implementadas Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //--------------------------
        // construtor
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }
        //--------------------------

        // Properties customizadas

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }        
        //--------------------------

        // métodos
        public override string ToString()
        {
            return $"{_nome}, $ { Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
        }

        public void RemoveProdutos(int quantity)
        {
            Quantidade -= quantity;

        }
        //--------------------------

    }
}
