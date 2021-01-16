
namespace RelatorioTurma.Models
{
    class Aluno
    {
        public string Nome { get; set; }
        public double NotaPr1 { get; set; }
        public double NotaPr2 { get; set; }
        public int NumeroDeFaltas { get; set; }

        public Aluno(string nome, double notaPr1, double notaPr2, int numeroDeFaltas)
        {
            Nome = nome;
            NotaPr1 = notaPr1;
            NotaPr2 = notaPr2;
            NumeroDeFaltas = numeroDeFaltas;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} Pr1: {NotaPr1} Pr2: {NotaPr2}";
        }
    }
}
