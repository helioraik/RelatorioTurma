using RelatorioTurma.Services;
using System;
using System.IO;


namespace RelatorioTurma.Repository
{
    class DbStatusAlunos
    {   
        private string caminhoArquivo = @"C:\Windows\Temp\escola_dorione_notas.csv";
        
            
        public void gravaStatusAluno(AlunoResultado resAluno)
        {
            try
            {
                string linhaCsv = resAluno.Nome + "|" + resAluno.Media + "|" + resAluno.StatusDoALuno;
                
                using (StreamWriter sw = new StreamWriter(new FileStream(caminhoArquivo, FileMode.Append)))
                {
                    sw.WriteLine(linhaCsv);
                }
                
                
            }
            catch(Exception e)
            {
                throw new Exception("Error: " + e.Message);
            }  
        }

        public void dbListarAlunos()
        {
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(caminhoArquivo, FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                    {

                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error:" + e.Message);
            }

        }
    }
}
