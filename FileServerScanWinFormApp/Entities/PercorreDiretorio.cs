using System.IO;
using System.Collections.Generic;
using System;

namespace FileServerScanWinFormApp.Entities
{
    public class PercorreDiretorio : IDisposable
    {        
        public delegate void DelegateDiretorio(string arquivoAtual, string palavraProcurada);
        public event DelegateDiretorio EvtDiretorio;
        
        public void EncontraArquivos(string caminhoDiretorio, string palavraProcurada)
        {
            try
            {
                var arquivos = Directory.EnumerateFiles(caminhoDiretorio, "*.*", SearchOption.AllDirectories);

                foreach (string arquivoAtual in arquivos)
                {
                    EvtDiretorio?.Invoke(arquivoAtual, palavraProcurada);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }

        #region "Rotinas"
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        ~PercorreDiretorio()
        {
            Dispose();
        }
        #endregion
    }
}
