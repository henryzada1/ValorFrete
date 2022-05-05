
namespace ValorFrete.view
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPorcFrete = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.cboUF1 = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbPorcFrete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(287, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(92, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de Frete";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(85, 111);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(85, 155);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 15);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblPorcFrete
            // 
            this.lblPorcFrete.AutoSize = true;
            this.lblPorcFrete.Location = new System.Drawing.Point(85, 200);
            this.lblPorcFrete.Name = "lblPorcFrete";
            this.lblPorcFrete.Size = new System.Drawing.Size(46, 15);
            this.lblPorcFrete.TabIndex = 3;
            this.lblPorcFrete.Text = "% Frete";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(379, 155);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(24, 15);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "UF:";
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorFrete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorFrete.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorFrete.Location = new System.Drawing.Point(85, 258);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(453, 158);
            this.lblValorFrete.TabIndex = 5;
            this.lblValorFrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboUF1
            // 
            this.cboUF1.FormattingEnabled = true;
            this.cboUF1.Items.AddRange(new object[] {
            "Escolha UF",
            "AC",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF1.Location = new System.Drawing.Point(423, 152);
            this.cboUF1.Name = "cboUF1";
            this.cboUF1.Size = new System.Drawing.Size(115, 23);
            this.cboUF1.TabIndex = 6;
            this.cboUF1.SelectedIndexChanged += new System.EventHandler(this.cboUF1_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(436, 197);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(152, 108);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(386, 23);
            this.tbCliente.TabIndex = 8;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(152, 152);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(139, 23);
            this.tbValor.TabIndex = 9;
            this.tbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPorcFrete
            // 
            this.tbPorcFrete.Location = new System.Drawing.Point(152, 197);
            this.tbPorcFrete.Name = "tbPorcFrete";
            this.tbPorcFrete.Size = new System.Drawing.Size(139, 23);
            this.tbPorcFrete.TabIndex = 10;
            this.tbPorcFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.tbPorcFrete);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboUF1);
            this.Controls.Add(this.lblValorFrete);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPorcFrete);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "TelaPrincipal";
            this.Text = "Sistema de Cálculo de Frete";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaPrincipal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPorcFrete;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblValorFrete;
        private System.Windows.Forms.ComboBox cboUF1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbPorcFrete;
    }
}