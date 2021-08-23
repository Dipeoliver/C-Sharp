namespace ExercicioClasseEstatica
{
    class Cotacao
    {
        public static double ValorDolar;
        public static double Quantidade;
        public static double ValorPago()
        {
            return (ValorDolar * Quantidade) + ((ValorDolar * Quantidade) * 0.06);
        }
    }
}
