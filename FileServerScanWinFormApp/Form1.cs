using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileServerScanWinFormApp.Entities;

namespace FileServerScanWinFormApp
{
    public partial class Form1 : Form
    {
        private PercorreDiretorio percorreDiretorio = new PercorreDiretorio();
        private PercorreArquivo palavra = new PercorreArquivo();

        public Form1()
        {
            InitializeComponent();
            percorreDiretorio.EvtDiretorio += PercorreDiretorio_EvtDiretorio;
            palavra.EvtArquivo += Palavra_EvtArquivo;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            percorreDiretorio.EvtDiretorio -= PercorreDiretorio_EvtDiretorio;
            palavra.EvtArquivo -= Palavra_EvtArquivo;
        }

        private void PercorreDiretorio_EvtDiretorio(string arquivoAtual, string palavraProcurada)
        {
            Task task1 = Task.Factory.StartNew(() => palavra.ProcuraPalavra(arquivoAtual, palavraProcurada));            
        }

        private void Palavra_EvtArquivo(string CaminhoDoArquivoComPalavra)
        {
            lstBxListaArquivos.Invoke(new Action(() => lstBxListaArquivos.Items.Insert(0, CaminhoDoArquivoComPalavra)));
        }
        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            percorreDiretorio.EncontraArquivos(txtDiretorio.Text, txtPalavra.Text);
        }
    }
}