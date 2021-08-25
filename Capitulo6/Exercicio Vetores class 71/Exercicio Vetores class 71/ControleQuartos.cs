
namespace Exercicio_Vetores_class_71
{
    class ControleQuartos
    {
        // atributos
         string Name { get; set; }
         string Email { get; set; }

        // construtor
        public ControleQuartos(string nome, string email)
        {
            Name = nome;
            Email = email;
        }

        // métodos
        public override string ToString()
        {
            return $": {Name}, {Email}";
        }

    }
}
