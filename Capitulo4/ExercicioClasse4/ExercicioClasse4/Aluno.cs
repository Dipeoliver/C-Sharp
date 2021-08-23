

namespace ExercicioClasse4
{
    class Aluno
    {
        public string Nome;
        public double nota1;
        public double nota2;
        public double nota3;

        double notaFinal = 0;

        public double NotaFinal()
        {
            notaFinal = nota1 + nota2 + nota3;
            return notaFinal;
        }

        public string Avaliação()
        {
            if (notaFinal > 60.00) return "APROVADO";
            else return "REPROVADO";
        }

        public double NotaFalta()
        {
            if (notaFinal < 60.00)
            {
                return (60.00 - notaFinal);
            }
            else
                return 0;
        }


    }
}
