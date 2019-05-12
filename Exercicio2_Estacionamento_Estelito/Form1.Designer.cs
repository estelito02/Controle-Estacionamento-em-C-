namespace Exercicio2_Estacionamento_Estelito
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltotalvagas = new System.Windows.Forms.Label();
            this.lblvagasdisponiveis = new System.Windows.Forms.Label();
            this.lblnumerovagas = new System.Windows.Forms.Label();
            this.gpxControle = new System.Windows.Forms.GroupBox();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnabrir = new System.Windows.Forms.Button();
            this.txtVagas = new System.Windows.Forms.TextBox();
            this.gpxControle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltotalvagas
            // 
            this.lbltotalvagas.AutoSize = true;
            this.lbltotalvagas.Location = new System.Drawing.Point(33, 26);
            this.lbltotalvagas.Name = "lbltotalvagas";
            this.lbltotalvagas.Size = new System.Drawing.Size(64, 13);
            this.lbltotalvagas.TabIndex = 0;
            this.lbltotalvagas.Text = "Total Vagas";
            // 
            // lblvagasdisponiveis
            // 
            this.lblvagasdisponiveis.AutoSize = true;
            this.lblvagasdisponiveis.Location = new System.Drawing.Point(89, 44);
            this.lblvagasdisponiveis.Name = "lblvagasdisponiveis";
            this.lblvagasdisponiveis.Size = new System.Drawing.Size(94, 13);
            this.lblvagasdisponiveis.TabIndex = 1;
            this.lblvagasdisponiveis.Text = "Vagas Disponiveis";
            // 
            // lblnumerovagas
            // 
            this.lblnumerovagas.AutoSize = true;
            this.lblnumerovagas.Location = new System.Drawing.Point(116, 90);
            this.lblnumerovagas.Name = "lblnumerovagas";
            this.lblnumerovagas.Size = new System.Drawing.Size(13, 13);
            this.lblnumerovagas.TabIndex = 2;
            this.lblnumerovagas.Text = "0";
            // 
            // gpxControle
            // 
            this.gpxControle.Controls.Add(this.lblvagasdisponiveis);
            this.gpxControle.Controls.Add(this.lblnumerovagas);
            this.gpxControle.Location = new System.Drawing.Point(12, 71);
            this.gpxControle.Name = "gpxControle";
            this.gpxControle.Size = new System.Drawing.Size(245, 149);
            this.gpxControle.TabIndex = 3;
            this.gpxControle.TabStop = false;
            this.gpxControle.Text = "Controle de Vagas";
            // 
            // btnSaida
            // 
            this.btnSaida.Enabled = false;
            this.btnSaida.Location = new System.Drawing.Point(330, 133);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(147, 23);
            this.btnSaida.TabIndex = 3;
            this.btnSaida.Text = "Saida";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Enabled = false;
            this.btnEntrada.Location = new System.Drawing.Point(330, 82);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(147, 23);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(330, 26);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(147, 23);
            this.btnabrir.TabIndex = 5;
            this.btnabrir.Text = "Abrir Estacionamento";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // txtVagas
            // 
            this.txtVagas.Location = new System.Drawing.Point(104, 23);
            this.txtVagas.Name = "txtVagas";
            this.txtVagas.Size = new System.Drawing.Size(141, 20);
            this.txtVagas.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 197);
            this.Controls.Add(this.txtVagas);
            this.Controls.Add(this.btnabrir);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.gpxControle);
            this.Controls.Add(this.lbltotalvagas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpxControle.ResumeLayout(false);
            this.gpxControle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalvagas;
        private System.Windows.Forms.Label lblvagasdisponiveis;
        private System.Windows.Forms.Label lblnumerovagas;
        private System.Windows.Forms.GroupBox gpxControle;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.TextBox txtVagas;
    }
}

