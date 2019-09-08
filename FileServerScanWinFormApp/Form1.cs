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
using FileServerScanWinFormApp.Entities;

namespace FileServerScanWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listaDeArquivosComAPalavra = new List<string>();
        PercorreArquivo palavraProcurada;
        List<PercorreArquivo> ImprimirLista = new List<PercorreArquivo>();
        int cont = 0;

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var percorreDiretorio = new PercorreDiretorio(txtDiretorio.Text);
            percorreDiretorio.EncontraArquivos();

            var listaDeArquivos = percorreDiretorio.RetornaListaArquivosDoDiretorio();
            
            foreach (var obj in listaDeArquivos)
            {
                palavraProcurada = new PercorreArquivo(obj, txtPalavra.Text);                
                var verificador = palavraProcurada.ProcuraPalavra();

                if (verificador)
                {
                    lstBxListaArquivos.Items.Add(obj);
                    cont++;
                }
            }

            MessageBox.Show($"Encontrado(s) {cont.ToString()} arquivo(s) com a palavra procurada.", "Resultado");
            cont = 0;
            
        }
    }
}