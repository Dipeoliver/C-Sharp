using System.Globalization;


namespace Sexto
{
    class Produto
    {
        // atributos
        private string _nome;
        private double _preco;
        private int _quantidade;
        //--------------------------
        // construtor
        public Produto()
        {

        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }
        //--------------------------
        // Encapsulamento
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }


        //--------------------------
        // métodos
        public override string ToString()
        {
            return $"{_nome}, $ { _preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoveProdutos(int quantity)
        {
            _quantidade -= quantity;

        }
        //--------------------------

    }
}
