using System.Globalization;


namespace Sexto
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public override string ToString()
        {
            return $"{Nome}, $ { Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
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
    }
}
