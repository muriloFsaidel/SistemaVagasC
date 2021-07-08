namespace SistemaVagas
{
    partial class MenuVagas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVagas));
            this.btCadastrarVaga = new System.Windows.Forms.Button();
            this.btConsultarVagas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btEncerrarAp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarVaga
            // 
            this.btCadastrarVaga.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCadastrarVaga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarVaga.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btCadastrarVaga.Location = new System.Drawing.Point(217, 235);
            this.btCadastrarVaga.Name = "btCadastrarVaga";
            this.btCadastrarVaga.Size = new System.Drawing.Size(200, 50);
            this.btCadastrarVaga.TabIndex = 0;
            this.btCadastrarVaga.Text = "Cadastrar Vagas";
            this.btCadastrarVaga.UseVisualStyleBackColor = false;
            this.btCadastrarVaga.Click += new System.EventHandler(this.btCadastrarVaga_Click);
            // 
            // btConsultarVagas
            // 
            this.btConsultarVagas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btConsultarVagas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsultarVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarVagas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btConsultarVagas.Location = new System.Drawing.Point(496, 235);
            this.btConsultarVagas.Name = "btConsultarVagas";
            this.btConsultarVagas.Size = new System.Drawing.Size(200, 50);
            this.btConsultarVagas.TabIndex = 1;
            this.btConsultarVagas.Text = "Consultar Vagas";
            this.btConsultarVagas.UseVisualStyleBackColor = false;
            this.btConsultarVagas.Click += new System.EventHandler(this.btConsultarVagas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Vagas";
            // 
            // btEncerrarAp
            // 
            this.btEncerrarAp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btEncerrarAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarAp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEncerrarAp.Location = new System.Drawing.Point(217, 346);
            this.btEncerrarAp.Name = "btEncerrarAp";
            this.btEncerrarAp.Size = new System.Drawing.Size(479, 43);
            this.btEncerrarAp.TabIndex = 32;
            this.btEncerrarAp.Text = "Encerrar Aplicação";
            this.btEncerrarAp.UseVisualStyleBackColor = false;
            this.btEncerrarAp.Click += new System.EventHandler(this.btEncerrarAp_Click);
            // 
            // MenuVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(929, 595);
            this.ControlBox = false;
            this.Controls.Add(this.btEncerrarAp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultarVagas);
            this.Controls.Add(this.btCadastrarVaga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuVagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuVagas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarVaga;
        private System.Windows.Forms.Button btConsultarVagas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEncerrarAp;
    }
}

