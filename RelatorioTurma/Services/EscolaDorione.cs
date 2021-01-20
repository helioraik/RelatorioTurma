using RelatorioTurma.Enums;
using RelatorioTurma.Models;
using RelatorioTurma.Repository;
using System;
using System.Collections.Generic;

namespace RelatorioTurma.Services
{
    class AlunoResultado
    {
        public string Nome { get; set; }
        public double Media { get; set; }
        public StatusDoAluno StatusDoALuno { get; set; }

        public AlunoResultado(string nome, double media, StatusDoAluno statusDoALuno)
        {
            Nome = nome;
            Media = media;
            StatusDoALuno = statusDoALuno;
        }
    }
    public class EscolaDorione
    {
        DbStatusAlunos dbAluno = new DbStatusAlunos();
        private const double NotaDeCorte = 7.0;
        private const int numeroAulasDadas = 30;
        private int limiteFaltas = (int) (numeroAulasDadas * 0.25);
        public void ProcessaStatusAlunos(List<Aluno> alunos)
        {
            

            if (alunos == null)
            {
                throw new ArgumentException("A lista de alunos esta vazia.Por favor inseir alunos antes de executar relatorio.");
            }

            double mediaAluno = 0.0;

            foreach (Aluno aluno in alunos)
            {
                mediaAluno = (aluno.NotaPr1 + aluno.NotaPr2) / 2;
                bool frequenciaAluno = aluno.NumeroDeFaltas >= limiteFaltas;

                if(mediaAluno >= NotaDeCorte && frequenciaAluno)
                {
                    AlunoResultado resAluno = new AlunoResultado(aluno.Nome, mediaAluno, StatusDoAluno.Aprovado);
                    dbAluno.gravaStatusAluno(resAluno);
                }
                else
                {
                    AlunoResultado resAluno = new AlunoResultado(aluno.Nome, mediaAluno, StatusDoAluno.Reprovado);
                    dbAluno.gravaStatusAluno(resAluno);
                }
            }
        }


        public void listarAlunos()
        {
            dbAluno.dbListarAlunos();
        }

    }

    
}
