using RelatorioTurma.Models;
using RelatorioTurma.Services;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace RelatorioTurma
{
    class Program
    {
        public static void Main(string[] args)
        {
            EscolaDorione ed = new EscolaDorione();
            List<Aluno> listAlunos = new List<Aluno>();

            int opcao = -1;

            while(opcao != 0)
            {
                Console.WriteLine("\t\tMenu Escola Dorione");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Listar Alunos");
                Console.WriteLine("3 - Sair");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    bool deseja = true;
                    while(deseja)
                    {
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();

                        Console.Write("Nota prova 1: ");
                        double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Nota prova 2: ");
                        double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Numero de faltas: ");
                        int numeroFaltas = int.Parse(Console.ReadLine());

                        listAlunos.Add(new Aluno(nome, nota1, nota2, numeroFaltas));

                        Console.ReadKey();
                        Console.Clear();

                        Console.Write("Deseja adicionar mais um aluno[s/n]? ");
                        char op = char.Parse(Console.ReadLine());

                        deseja = op == 'n' ? deseja = false : deseja = true;
                    }

                }
                else if(opcao == 2)
                {
                    ed.listarAlunos();
                }
                else if (opcao == 3)
                {
                    Environment.Exit(1);
                }

                ed.ProcessaStatusAlunos(listAlunos);
            }
            
        }
    }
}
