namespace prjFolhaPagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.txMatricula = new System.Windows.Forms.TextBox();
            this.txHoras = new System.Windows.Forms.TextBox();
            this.lbHoras = new System.Windows.Forms.Label();
            this.btBusca = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(338, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(103, 15);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Folha Pagamento ";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(25, 56);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(57, 15);
            this.lbMatricula.TabIndex = 1;
            this.lbMatricula.Text = "Matricula";
            // 
            // txMatricula
            // 
            this.txMatricula.Location = new System.Drawing.Point(25, 74);
            this.txMatricula.Name = "txMatricula";
            this.txMatricula.Size = new System.Drawing.Size(100, 23);
            this.txMatricula.TabIndex = 2;
            // 
            // txHoras
            // 
            this.txHoras.Location = new System.Drawing.Point(25, 139);
            this.txHoras.Name = "txHoras";
            this.txHoras.Size = new System.Drawing.Size(100, 23);
            this.txHoras.TabIndex = 4;
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Location = new System.Drawing.Point(25, 121);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(85, 15);
            this.lbHoras.TabIndex = 3;
            this.lbHoras.Text = "Número Horas";
            // 
            // btBusca
            // 
            this.btBusca.Location = new System.Drawing.Point(145, 76);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(75, 23);
            this.btBusca.TabIndex = 5;
            this.btBusca.Text = "BUSCA";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(145, 139);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Location = new System.Drawing.Point(25, 168);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.Size = new System.Drawing.Size(749, 240);
            this.txRelatorio.TabIndex = 7;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(696, 419);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 15);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total: ";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(258, 80);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 15);
            this.lbNome.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.txHoras);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.txMatricula);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitulo;
        private Label lbMatricula;
        private TextBox txMatricula;
        private TextBox txHoras;
        private Label lbHoras;
        private Button btBusca;
        private Button btOk;
        private TextBox txRelatorio;
        private Label lbTotal;
        private Label lbNome;
    }
}