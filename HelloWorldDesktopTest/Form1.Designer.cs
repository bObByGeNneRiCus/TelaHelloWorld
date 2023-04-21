namespace HelloWorldDesktopTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lbxDados = new System.Windows.Forms.ListBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pbxCorFundo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.lbxDados);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.pbxCorFundo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 413);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 368);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(428, 38);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lbxDados
            // 
            this.lbxDados.FormattingEnabled = true;
            this.lbxDados.ItemHeight = 15;
            this.lbxDados.Location = new System.Drawing.Point(12, 148);
            this.lbxDados.Name = "lbxDados";
            this.lbxDados.Size = new System.Drawing.Size(428, 214);
            this.lbxDados.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.Location = new System.Drawing.Point(306, 99);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // pbxCorFundo
            // 
            this.pbxCorFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxCorFundo.Location = new System.Drawing.Point(95, 99);
            this.pbxCorFundo.Name = "pbxCorFundo";
            this.pbxCorFundo.Size = new System.Drawing.Size(152, 30);
            this.pbxCorFundo.TabIndex = 5;
            this.pbxCorFundo.TabStop = false;
            this.pbxCorFundo.Click += new System.EventHandler(this.pbxCorFundo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cor de fundo";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(253, 70);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PlaceholderText = "Número";
            this.txtNumero.Size = new System.Drawing.Size(187, 23);
            this.txtNumero.TabIndex = 3;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(12, 70);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.PlaceholderText = "Complemento";
            this.txtComplemento.Size = new System.Drawing.Size(235, 23);
            this.txtComplemento.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 41);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PlaceholderText = "Endereço";
            this.txtEndereco.Size = new System.Drawing.Size(428, 23);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(428, 23);
            this.txtNome.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 413);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hello World!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCorFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private PictureBox pbxCorFundo;
        private Label label1;
        private Button btnLimpar;
        private ListBox lbxDados;
        private Button btnGravar;
    }
}