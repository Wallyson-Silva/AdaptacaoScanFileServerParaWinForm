namespace FileServerScanWinFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDiretorio = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lstBxListaArquivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDiretorio
            // 
            this.lblDiretorio.AutoSize = true;
            this.lblDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiretorio.Location = new System.Drawing.Point(8, 9);
            this.lblDiretorio.Name = "lblDiretorio";
            this.lblDiretorio.Size = new System.Drawing.Size(155, 20);
            this.lblDiretorio.TabIndex = 0;
            this.lblDiretorio.Text = "Caminho do diretório";
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(15, 39);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(137, 20);
            this.lblPalavra.TabIndex = 1;
            this.lblPalavra.Text = "Palavra procurada";
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(169, 9);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(389, 20);
            this.txtDiretorio.TabIndex = 2;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(169, 40);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(389, 20);
            this.txtPalavra.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(575, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 28);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lstBxListaArquivos
            // 
            this.lstBxListaArquivos.FormattingEnabled = true;
            this.lstBxListaArquivos.Location = new System.Drawing.Point(12, 204);
            this.lstBxListaArquivos.Name = "lstBxListaArquivos";
            this.lstBxListaArquivos.Size = new System.Drawing.Size(650, 251);
            this.lstBxListaArquivos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.lstBxListaArquivos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.lblPalavra);
            this.Controls.Add(this.lblDiretorio);
            this.Name = "Form1";
            this.Text = "TP Scan File Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiretorio;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListBox lstBxListaArquivos;
    }
}

