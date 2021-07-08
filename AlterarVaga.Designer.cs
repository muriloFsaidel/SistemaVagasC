namespace SistemaVagas
{
    partial class AlterarVaga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarVaga));
            this.bAlterarVaga = new System.Windows.Forms.Button();
            this.rbSuperior = new System.Windows.Forms.RadioButton();
            this.rbTecnico = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbFundamental = new System.Windows.Forms.RadioButton();
            this.tbRequisitos = new System.Windows.Forms.TextBox();
            this.tbEmailContato = new System.Windows.Forms.TextBox();
            this.tbFaixaSalarial = new System.Windows.Forms.TextBox();
            this.tbVaga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btVoltarConsultarVagas = new System.Windows.Forms.Button();
            this.vagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBsistema_de_vagasDataSet = new SistemaVagas.DBsistema_de_vagasDataSet();
            this.vagaTableAdapter = new SistemaVagas.DBsistema_de_vagasDataSetTableAdapters.vagaTableAdapter();
            this.tableAdapterManager = new SistemaVagas.DBsistema_de_vagasDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBsistema_de_vagasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bAlterarVaga
            // 
            this.bAlterarVaga.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bAlterarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlterarVaga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bAlterarVaga.Location = new System.Drawing.Point(298, 534);
            this.bAlterarVaga.Name = "bAlterarVaga";
            this.bAlterarVaga.Size = new System.Drawing.Size(423, 43);
            this.bAlterarVaga.TabIndex = 28;
            this.bAlterarVaga.Text = "Alterar Vaga";
            this.bAlterarVaga.UseVisualStyleBackColor = false;
            this.bAlterarVaga.Click += new System.EventHandler(this.bAlterarVaga_Click);
            // 
            // rbSuperior
            // 
            this.rbSuperior.AutoSize = true;
            this.rbSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuperior.Location = new System.Drawing.Point(502, 475);
            this.rbSuperior.Name = "rbSuperior";
            this.rbSuperior.Size = new System.Drawing.Size(140, 24);
            this.rbSuperior.TabIndex = 27;
            this.rbSuperior.TabStop = true;
            this.rbSuperior.Text = "Ensino Superior";
            this.rbSuperior.UseVisualStyleBackColor = true;
            this.rbSuperior.CheckedChanged += new System.EventHandler(this.rbSuperior_CheckedChanged);
            // 
            // rbTecnico
            // 
            this.rbTecnico.AutoSize = true;
            this.rbTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTecnico.Location = new System.Drawing.Point(502, 429);
            this.rbTecnico.Name = "rbTecnico";
            this.rbTecnico.Size = new System.Drawing.Size(135, 24);
            this.rbTecnico.TabIndex = 26;
            this.rbTecnico.TabStop = true;
            this.rbTecnico.Text = "Ensino Técnico";
            this.rbTecnico.UseVisualStyleBackColor = true;
            this.rbTecnico.CheckedChanged += new System.EventHandler(this.rbTecnico_CheckedChanged);
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedio.Location = new System.Drawing.Point(308, 475);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(123, 24);
            this.rbMedio.TabIndex = 25;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Ensino Médio";
            this.rbMedio.UseVisualStyleBackColor = true;
            this.rbMedio.CheckedChanged += new System.EventHandler(this.rbMedio_CheckedChanged);
            // 
            // rbFundamental
            // 
            this.rbFundamental.AutoSize = true;
            this.rbFundamental.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFundamental.Location = new System.Drawing.Point(308, 429);
            this.rbFundamental.Name = "rbFundamental";
            this.rbFundamental.Size = new System.Drawing.Size(174, 24);
            this.rbFundamental.TabIndex = 24;
            this.rbFundamental.TabStop = true;
            this.rbFundamental.Text = "Ensino Fundamental";
            this.rbFundamental.UseVisualStyleBackColor = true;
            this.rbFundamental.CheckedChanged += new System.EventHandler(this.rbFundamental_CheckedChanged);
            // 
            // tbRequisitos
            // 
            this.tbRequisitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequisitos.Location = new System.Drawing.Point(308, 247);
            this.tbRequisitos.Multiline = true;
            this.tbRequisitos.Name = "tbRequisitos";
            this.tbRequisitos.Size = new System.Drawing.Size(413, 152);
            this.tbRequisitos.TabIndex = 23;
            // 
            // tbEmailContato
            // 
            this.tbEmailContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailContato.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbEmailContato.Location = new System.Drawing.Point(308, 179);
            this.tbEmailContato.Name = "tbEmailContato";
            this.tbEmailContato.Size = new System.Drawing.Size(413, 26);
            this.tbEmailContato.TabIndex = 22;
            // 
            // tbFaixaSalarial
            // 
            this.tbFaixaSalarial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFaixaSalarial.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbFaixaSalarial.Location = new System.Drawing.Point(308, 122);
            this.tbFaixaSalarial.Name = "tbFaixaSalarial";
            this.tbFaixaSalarial.Size = new System.Drawing.Size(413, 26);
            this.tbFaixaSalarial.TabIndex = 21;
            // 
            // tbVaga
            // 
            this.tbVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVaga.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbVaga.Location = new System.Drawing.Point(308, 65);
            this.tbVaga.Name = "tbVaga";
            this.tbVaga.Size = new System.Drawing.Size(413, 26);
            this.tbVaga.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(151, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Escolaridade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(151, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Requisitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(123, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email para contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(151, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Faixa Salarial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(211, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cargo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 29);
            this.label7.TabIndex = 30;
            this.label7.Text = "Alterar Vaga";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btVoltarConsultarVagas
            // 
            this.btVoltarConsultarVagas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btVoltarConsultarVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarConsultarVagas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btVoltarConsultarVagas.Location = new System.Drawing.Point(298, 601);
            this.btVoltarConsultarVagas.Name = "btVoltarConsultarVagas";
            this.btVoltarConsultarVagas.Size = new System.Drawing.Size(423, 43);
            this.btVoltarConsultarVagas.TabIndex = 31;
            this.btVoltarConsultarVagas.Text = "Voltar";
            this.btVoltarConsultarVagas.UseVisualStyleBackColor = false;
            this.btVoltarConsultarVagas.Click += new System.EventHandler(this.btVoltarConsultarVagas_Click);
            // 
            // vagaBindingSource
            // 
            this.vagaBindingSource.DataMember = "vaga";
            this.vagaBindingSource.DataSource = this.dBsistema_de_vagasDataSet;
            // 
            // dBsistema_de_vagasDataSet
            // 
            this.dBsistema_de_vagasDataSet.DataSetName = "DBsistema_de_vagasDataSet";
            this.dBsistema_de_vagasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vagaTableAdapter
            // 
            this.vagaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SistemaVagas.DBsistema_de_vagasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vagaTableAdapter = this.vagaTableAdapter;
            // 
            // AlterarVaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(872, 695);
            this.ControlBox = false;
            this.Controls.Add(this.btVoltarConsultarVagas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bAlterarVaga);
            this.Controls.Add(this.rbSuperior);
            this.Controls.Add(this.rbTecnico);
            this.Controls.Add(this.rbMedio);
            this.Controls.Add(this.rbFundamental);
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
            this.Name = "AlterarVaga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarVaga";
            this.Load += new System.EventHandler(this.AlterarVaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBsistema_de_vagasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAlterarVaga;
        private System.Windows.Forms.RadioButton rbSuperior;
        private System.Windows.Forms.RadioButton rbTecnico;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbFundamental;
        private System.Windows.Forms.TextBox tbRequisitos;
        private System.Windows.Forms.TextBox tbEmailContato;
        private System.Windows.Forms.TextBox tbFaixaSalarial;
        private System.Windows.Forms.TextBox tbVaga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btVoltarConsultarVagas;
        private DBsistema_de_vagasDataSet dBsistema_de_vagasDataSet;
        private System.Windows.Forms.BindingSource vagaBindingSource;
        private DBsistema_de_vagasDataSetTableAdapters.vagaTableAdapter vagaTableAdapter;
        private DBsistema_de_vagasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}