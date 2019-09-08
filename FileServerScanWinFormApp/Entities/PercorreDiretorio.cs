using System.IO;
using System.Collections.Generic;
using System;

namespace FileServerScanWinFormApp.Entities
{
    class PercorreDiretorio
    {
        public string CaminhoDiretorio { get; set; }
        private List<string> ListaDeArquivosDiretorio = new List<string>();


        public PercorreDiretorio()
        {
        }

        public PercorreDiretorio(string caminhoDiretorio)
        {
            CaminhoDiretorio = caminhoDiretorio;
        }     


        public void EncontraArquivos()
        {
            try
            {
                var arquivos = Directory.EnumerateFiles(CaminhoDiretorio, "*.*", SearchOption.AllDirectories);

                foreach (string arquivoAtual in arquivos)
                {
                    ListaDeArquivosDiretorio.Add(arquivoAtual);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }

        public List<string> RetornaListaArquivosDoDiretorio()
        {
            return ListaDeArquivosDiretorio;
        }

    }
}
