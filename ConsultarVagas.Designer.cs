namespace SistemaVagas
{
    partial class ConsultarVagas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVagas));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.btConsultarVaga = new System.Windows.Forms.Button();
            this.btAlterarVaga = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.dBsistema_de_vagasDataSet = new SistemaVagas.DBsistema_de_vagasDataSet();
            this.vagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vagaTableAdapter = new SistemaVagas.DBsistema_de_vagasDataSetTableAdapters.vagaTableAdapter();
            this.tableAdapterManager = new SistemaVagas.DBsistema_de_vagasDataSetTableAdapters.TableAdapterManager();
            this.vagaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vagaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.vagaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dBsistema_de_vagasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargo:";
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(205, 196);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(279, 20);
            this.tbCargo.TabIndex = 2;
            // 
            // btConsultarVaga
            // 
            this.btConsultarVaga.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btConsultarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVaga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btConsultarVaga.Location = new System.Drawing.Point(509, 160);
            this.btConsultarVaga.Name = "btConsultarVaga";
            this.btConsultarVaga.Size = new System.Drawing.Size(169, 36);
            this.btConsultarVaga.TabIndex = 4;
            this.btConsultarVaga.Text = "Consultar Vaga";
            this.btConsultarVaga.UseVisualStyleBackColor = false;
            this.btConsultarVaga.Click += new System.EventHandler(this.btConsultarVaga_Click);
            // 
            // btAlterarVaga
            // 
            this.btAlterarVaga.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btAlterarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarVaga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAlterarVaga.Location = new System.Drawing.Point(509, 207);
            this.btAlterarVaga.Name = "btAlterarVaga";
            this.btAlterarVaga.Size = new System.Drawing.Size(169, 36);
            this.btAlterarVaga.TabIndex = 5;
            this.btAlterarVaga.Text = "Alterar Vaga";
            this.btAlterarVaga.UseVisualStyleBackColor = false;
            this.btAlterarVaga.Click += new System.EventHandler(this.btAlterarVaga_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Consulta de vagas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Para consultar ou alterar uma vaga específica, informe o cargo sem espaços antes " +
    "ou depois.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btVoltar.Location = new System.Drawing.Point(696, 160);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(211, 36);
            this.btVoltar.TabIndex = 9;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // dBsistema_de_vagasDataSet
            // 
            this.dBsistema_de_vagasDataSet.DataSetName = "DBsistema_de_vagasDataSet";
            this.dBsistema_de_vagasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vagaBindingSource
            // 
            this.vagaBindingSource.DataMember = "vaga";
            this.vagaBindingSource.DataSource = this.dBsistema_de_vagasDataSet;
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
            // vagaBindingSource1
            // 
            this.vagaBindingSource1.DataMember = "vaga";
            this.vagaBindingSource1.DataSource = this.dBsistema_de_vagasDataSet;
            // 
            // vagaBindingSource2
            // 
            this.vagaBindingSource2.DataMember = "vaga";
            this.vagaBindingSource2.DataSource = this.dBsistema_de_vagasDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(696, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Recarregar Vagas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vagaDataGridView
            // 
            this.vagaDataGridView.AllowUserToDeleteRows = false;
            this.vagaDataGridView.AutoGenerateColumns = false;
            this.vagaDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.vagaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vagaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vagaDataGridView.DataSource = this.vagaBindingSource2;
            this.vagaDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.vagaDataGridView.Location = new System.Drawing.Point(28, 261);
            this.vagaDataGridView.Name = "vagaDataGridView";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vagaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vagaDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vagaDataGridView.RowTemplate.Height = 80;
            this.vagaDataGridView.RowTemplate.ReadOnly = true;
            this.vagaDataGridView.Size = new System.Drawing.Size(879, 319);
            this.vagaDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cargo";
            this.dataGridViewTextBoxColumn1.HeaderText = "cargo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "faixa_salarial";
            this.dataGridViewTextBoxColumn2.HeaderText = "faixa_salarial";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "requisitos";
            this.dataGridViewTextBoxColumn3.FillWeight = 250F;
            this.dataGridViewTextBoxColumn3.HeaderText = "requisitos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 190;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "escolaridade_minima";
            this.dataGridViewTextBoxColumn4.HeaderText = "escolaridade_minima";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email_empresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "email_empresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 190;
            // 
            // ConsultarVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(927, 592);
            this.ControlBox = false;
            this.Controls.Add(this.vagaDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAlterarVaga);
            this.Controls.Add(this.btConsultarVaga);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultarVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.ConsultarVagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBsistema_de_vagasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vagaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Button btConsultarVaga;
        private System.Windows.Forms.Button btAlterarVaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btVoltar;
        private DBsistema_de_vagasDataSet dBsistema_de_vagasDataSet;
        private System.Windows.Forms.BindingSource vagaBindingSource;
        private DBsistema_de_vagasDataSetTableAdapters.vagaTableAdapter vagaTableAdapter;
        private DBsistema_de_vagasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vagaBindingSource1;
        private System.Windows.Forms.BindingSource vagaBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView vagaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}