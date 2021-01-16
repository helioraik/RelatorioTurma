using RelatorioTurma.Models;
using System;
using System.Collections.Generic;

namespace RelatorioTurma.Services
{
    static class EscolaDorione
    {
        private const double NotaDeCorte = 7.0;
        public static void ProcessaStatusAlunos(List<Aluno> alunos)
        {
            if(alunos == null)
            {
                throw new ArgumentException("A lista de alunos não pode ser nula.");
            }

            double mediaAluno = 0.0;

            foreach (Aluno aluno in alunos)
            {
                mediaAluno = (aluno.NotaPr1 + aluno.NotaPr2) / 2;

                if(mediaAluno >= NotaDeCorte)
                {

                }
            }
        }
    }
}
