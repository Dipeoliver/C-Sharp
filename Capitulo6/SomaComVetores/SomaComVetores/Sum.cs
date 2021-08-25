namespace SomaComVetores
{
    class Sum
    {
        public static int sum(params int[] numbers)
        {
            int soma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                soma += numbers[i];
            }
            return soma;




        }
    }
}
