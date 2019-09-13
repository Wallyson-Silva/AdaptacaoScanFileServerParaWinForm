using System.IO;
using System.Text.RegularExpressions;
using System;

namespace FileServerScanWinFormApp.Entities
{
    public class PercorreArquivo : IDisposable
    {
        public delegate void DelegateArquivo(string CaminhoDoArquivoComPalavra);
        public event DelegateArquivo EvtArquivo;

        public void ProcuraPalavra(string caminhoDoArquivoAtual, string palavraProcurada)
        {
            try
            {
                using (StreamReader sr = File.OpenText(caminhoDoArquivoAtual))
                {
                    while (!sr.EndOfStream)
                    {
                        string linhaDoArquivo = sr.ReadLine();
                        foreach (Match match in Regex.Matches(linhaDoArquivo, palavraProcurada, RegexOptions.IgnoreCase))
                        {
                            EvtArquivo?.Invoke(caminhoDoArquivoAtual);
                        }
                    }
                }                           
            }
            catch (IOException e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            
        }

        #region "Rotinas"
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        ~PercorreArquivo()
        {
            Dispose();
        }
        #endregion
    }
}
