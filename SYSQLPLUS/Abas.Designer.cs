namespace SYSQLPLUS
{
    partial class Abas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAbrirCripto = new System.Windows.Forms.TextBox();
            this.picboxSair = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSair)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAbrirCripto);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 397);
            this.panel1.TabIndex = 14;
            // 
            // btAbrirCripto
            // 
            this.btAbrirCripto.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btAbrirCripto.BackColor = System.Drawing.Color.Black;
            this.btAbrirCripto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirCripto.ForeColor = System.Drawing.Color.Silver;
            this.btAbrirCripto.Location = new System.Drawing.Point(0, 0);
            this.btAbrirCripto.Multiline = true;
            this.btAbrirCripto.Name = "btAbrirCripto";
            this.btAbrirCripto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.btAbrirCripto.Size = new System.Drawing.Size(515, 397);
            this.btAbrirCripto.TabIndex = 21;
            this.btAbrirCripto.Text = "select sysdate from dual";
            this.btAbrirCripto.Visible = false;
            // 
            // picboxSair
            // 
            this.picboxSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxSair.Image = ((System.Drawing.Image)(resources.GetObject("picboxSair.Image")));
            this.picboxSair.Location = new System.Drawing.Point(542, 3);
            this.picboxSair.Name = "picboxSair";
            this.picboxSair.Size = new System.Drawing.Size(15, 15);
            this.picboxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxSair.TabIndex = 12;
            this.picboxSair.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picboxSair);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 21);
            this.panel2.TabIndex = 15;
            // 
            // Abas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Abas";
            this.Size = new System.Drawing.Size(594, 418);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSair)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox btAbrirCripto;
        private System.Windows.Forms.PictureBox picboxSair;
        private System.Windows.Forms.Panel panel2;
    }
}
