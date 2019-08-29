using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FileServerScanWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool contemPalavra = false;
       
        public void EncontraPalavra()
        {   
            var arquivos = Directory.EnumerateFiles(txtDiretorio.Text, "*.*", SearchOption.AllDirectories);

            foreach (string arquivoAtual in arquivos)
            {
                PercorreArquivo(arquivoAtual);
            }         

        }

        public void PercorreArquivo(string ArquivoAtual)
        {
            StreamReader sr;
            sr = File.OpenText(ArquivoAtual);
            while (!sr.EndOfStream)
            {
                string linhaDoArquivo = sr.ReadLine();
                foreach (Match match in Regex.Matches(linhaDoArquivo, txtPalavra.Text, RegexOptions.IgnoreCase))
                {
                    contemPalavra = true;
                    break;
                }
            }
            if (contemPalavra)
            {
                lstBxListaArquivos.Items.Add(ArquivoAtual);
                contemPalavra = false;
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            EncontraPalavra();           
        }

        
    }
}
