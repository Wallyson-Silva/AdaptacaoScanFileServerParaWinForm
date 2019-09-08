using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FileServerScanWinFormApp.Entities
{
    class PercorreArquivo
    {
        public string CaminhoDoArquivo { get; set; }
        public string PalavraProcurada { get; set; }
       
        public PercorreArquivo()
        {
        }

        public PercorreArquivo(string caminhoDoArquivo, string palavraProcurada)
        {
            CaminhoDoArquivo = caminhoDoArquivo;
            PalavraProcurada = palavraProcurada;
        }

        bool palavraExiste = false, auxPalavraExiste;
        public bool ProcuraPalavra()
        {
            StreamReader sr;
            sr = File.OpenText(CaminhoDoArquivo);
            while (!sr.EndOfStream)
            {
                string linhaDoArquivo = sr.ReadLine();
                foreach (Match match in Regex.Matches(linhaDoArquivo, PalavraProcurada, RegexOptions.IgnoreCase))
                {                    
                    palavraExiste = true;
                }
            }            
            sr.Close();
            auxPalavraExiste = palavraExiste;
            palavraExiste = false;
            return auxPalavraExiste;          
        }        
    }
}
