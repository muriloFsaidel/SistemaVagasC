namespace SistemaVagas
{
    partial class CadastrarVagas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarVagas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVaga = new System.Windows.Forms.TextBox();
            this.tbFaixaSalarial = new System.Windows.Forms.TextBox();
            this.tbEmailContato = new System.Windows.Forms.TextBox();
            this.tbRequisitos = new System.Windows.Forms.TextBox();
            this.rbFundamental = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.rbSuperior = new System.Windows.Forms.RadioButton();
            this.bInserirVaga = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbEscolaridade = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbEscolaridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(102, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(46, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faixa Salarial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email para contato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(46, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Requisitos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(46, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Escolaridade:";
            // 
            // tbVaga
            // 
            this.tbVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVaga.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbVaga.Location = new System.Drawing.Point(184, 95);
            this.tbVaga.Name = "tbVaga";
            this.tbVaga.Size = new System.Drawing.Size(365, 26);
            this.tbVaga.TabIndex = 5;
            // 
            // tbFaixaSalarial
            // 
            this.tbFaixaSalarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFaixaSalarial.ForeColor = System.Drawing.Color.Silver;
            this.tbFaixaSalarial.Location = new System.Drawing.Point(184, 152);
            this.tbFaixaSalarial.Name = "tbFaixaSalarial";
            this.tbFaixaSalarial.Size = new System.Drawing.Size(365, 26);
            this.tbFaixaSalarial.TabIndex = 6;
            this.tbFaixaSalarial.Text = "Ex: até 1.200, maior que 3000";
            this.tbFaixaSalarial.TextChanged += new System.EventHandler(this.tbFaixaSalarial_TextChanged);
            this.tbFaixaSalarial.Enter += new System.EventHandler(this.tbFaixaSalarial_Enter);
            this.tbFaixaSalarial.Leave += new System.EventHandler(this.tbFaixaSalarial_Leave);
            // 
            // tbEmailContato
            // 
            this.tbEmailContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailContato.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbEmailContato.Location = new System.Drawing.Point(184, 209);
            this.tbEmailContato.Name = "tbEmailContato";
            this.tbEmailContato.Size = new System.Drawing.Size(365, 26);
            this.tbEmailContato.TabIndex = 7;
            // 
            // tbRequisitos
            // 
            this.tbRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequisitos.Location = new System.Drawing.Point(184, 284);
            this.tbRequisitos.Multiline = true;
            this.tbRequisitos.Name = "tbRequisitos";
            this.tbRequisitos.Size = new System.Drawing.Size(365, 152);
            this.tbRequisitos.TabIndex = 8;
            // 
            // rbFundamental
            // 
            this.rbFundamental.AutoSize = true;
            this.rbFundamental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFundamental.Location = new System.Drawing.Point(6, 30);
            this.rbFundamental.Name = "rbFundamental";
            this.rbFundamental.Size = new System.Drawing.Size(174, 24);
            this.rbFundamental.TabIndex = 9;
            this.rbFundamental.TabStop = true;
            this.rbFundamental.Text = "Ensino Fundamental";
            this.rbFundamental.UseVisualStyleBackColor = true;
            this.rbFundamental.CheckedChanged += new System.EventHandler(this.rbFundamental_CheckedChanged);
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedio.Location = new System.Drawing.Point(6, 60);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(123, 24);
            this.rbMedio.TabIndex = 10;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Ensino Médio";
            this.rbMedio.UseVisualStyleBackColor = true;
            this.rbMedio.CheckedChanged += new System.EventHandler(this.rbMedio_CheckedChanged);
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTecnico.Location = new System.Drawing.Point(227, 30);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(135, 24);
            this.rbTecnico.TabIndex = 11;
            this.rbTecnico.TabStop = true;
            this.rbTecnico.Text = "Ensino Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            this.rbTecnico.CheckedChanged += new System.EventHandler(this.rbTecnico_CheckedChanged);
            // 
            // rbSuperior
            // 
            this.rbSuperior.AutoSize = true;
            this.rbSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuperior.Location = new System.Drawing.Point(227, 60);
            this.rbSuperior.Name = "rbSuperior";
            this.rbSuperior.Size = new System.Drawing.Size(140, 24);
            this.rbSuperior.TabIndex = 12;
            this.rbSuperior.TabStop = true;
            this.rbSuperior.Text = "Ensino Superior";
            this.rbSuperior.UseVisualStyleBackColor = true;
            this.rbSuperior.CheckedChanged += new System.EventHandler(this.rbSuperior_CheckedChanged);
            // 
            // bInserirVaga
            // 
            this.bInserirVaga.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bInserirVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInserirVaga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bInserirVaga.Location = new System.Drawing.Point(184, 602);
            this.bInserirVaga.Name = "bInserirVaga";
            this.bInserirVaga.Size = new System.Drawing.Size(365, 43);
            this.bInserirVaga.TabIndex = 13;
            this.bInserirVaga.Text = "Inserir Vaga";
            this.bInserirVaga.UseVisualStyleBackColor = false;
            this.bInserirVaga.Click += new System.EventHandler(this.bInserirVaga_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cadastrar Vagas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // gbEscolaridade
            // 
            this.gbEscolaridade.Controls.Add(this.rbFundamental);
            this.gbEscolaridade.Controls.Add(this.rbMedio);
            this.gbEscolaridade.Controls.Add(this.rbTecnico);
            this.gbEscolaridade.Controls.Add(this.rbSuperior);
            this.gbEscolaridade.Location = new System.Drawing.Point(184, 470);
            this.gbEscolaridade.Name = "gbEscolaridade";
            this.gbEscolaridade.Size = new System.Drawing.Size(374, 100);
            this.gbEscolaridade.TabIndex = 15;
            this.gbEscolaridade.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.MaximumSize = new System.Drawing.Size(120, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(32, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(555, 17);
            this.label8.TabIndex = 17;
            // 
            // CadastrarVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(589, 726);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbEscolaridade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bInserirVaga);
            this.Controls.Add(this.tbRequisitos);
            this.Controls.Add(this.tbEmailContato);
            this.Controls.Add(this.tbFaixaSalarial);
            this.Controls.Add(this.tbVaga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarVagas";
            this.gbEscolaridade.ResumeLayout(false);
            this.gbEscolaridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbVaga;
        private System.Windows.Forms.TextBox tbFaixaSalarial;
        private System.Windows.Forms.TextBox tbEmailContato;
        private System.Windows.Forms.TextBox tbRequisitos;
        private System.Windows.Forms.RadioButton rbFundamental;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.RadioButton rbSuperior;
        private System.Windows.Forms.Button bInserirVaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEscolaridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}