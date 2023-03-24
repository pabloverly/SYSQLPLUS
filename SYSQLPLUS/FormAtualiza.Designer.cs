namespace SYSQLPLUS
{
    partial class FormAtualiza
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSeparador2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMaquinaP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMaquinaR = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserR = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateR = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.bgWorkerIndeterminada = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTarefaIndeterminada = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btDiretorio = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersao,
            this.tsslSeparador2,
            this.tsslMaquinaP,
            this.tsslMaquinaR,
            this.toolStripStatusLabel1,
            this.tsslUserP,
            this.tsslUserR,
            this.toolStripStatusLabel3,
            this.tsslDateR,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslVersao
            // 
            this.tsslVersao.Name = "tsslVersao";
            this.tsslVersao.Size = new System.Drawing.Size(66, 17);
            this.tsslVersao.Text = "SisBreak 1.0";
            // 
            // tsslSeparador2
            // 
            this.tsslSeparador2.Name = "tsslSeparador2";
            this.tsslSeparador2.Size = new System.Drawing.Size(46, 17);
            this.tsslSeparador2.Text = "             ";
            // 
            // tsslMaquinaP
            // 
            this.tsslMaquinaP.Name = "tsslMaquinaP";
            this.tsslMaquinaP.Size = new System.Drawing.Size(55, 17);
            this.tsslMaquinaP.Text = "Maquina.:";
            // 
            // tsslMaquinaR
            // 
            this.tsslMaquinaR.Name = "tsslMaquinaR";
            this.tsslMaquinaR.Size = new System.Drawing.Size(15, 17);
            this.tsslMaquinaR.Text = "--";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel1.Text = "             ";
            // 
            // tsslUserP
            // 
            this.tsslUserP.Name = "tsslUserP";
            this.tsslUserP.Size = new System.Drawing.Size(51, 17);
            this.tsslUserP.Text = "Usuario.:";
            // 
            // tsslUserR
            // 
            this.tsslUserR.Name = "tsslUserR";
            this.tsslUserR.Size = new System.Drawing.Size(15, 17);
            this.tsslUserR.Text = "--";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel3.Text = "             ";
            // 
            // tsslDateR
            // 
            this.tsslDateR.Name = "tsslDateR";
            this.tsslDateR.Size = new System.Drawing.Size(15, 17);
            this.tsslDateR.Text = "--";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel2.Text = "             ";
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Wheat;
            this.progressBar2.Location = new System.Drawing.Point(208, 34);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(282, 39);
            this.progressBar2.TabIndex = 6;
            // 
            // bgWorkerIndeterminada
            // 
            this.bgWorkerIndeterminada.WorkerReportsProgress = true;
            this.bgWorkerIndeterminada.WorkerSupportsCancellation = true;
            this.bgWorkerIndeterminada.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerIndeterminada_DoWork);
            this.bgWorkerIndeterminada.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerIndeterminada_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // btnTarefaIndeterminada
            // 
            this.btnTarefaIndeterminada.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTarefaIndeterminada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTarefaIndeterminada.Enabled = false;
            this.btnTarefaIndeterminada.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnTarefaIndeterminada.Location = new System.Drawing.Point(234, 88);
            this.btnTarefaIndeterminada.Name = "btnTarefaIndeterminada";
            this.btnTarefaIndeterminada.Size = new System.Drawing.Size(219, 31);
            this.btnTarefaIndeterminada.TabIndex = 11;
            this.btnTarefaIndeterminada.Text = "Baixar Arquivos";
            this.btnTarefaIndeterminada.UseVisualStyleBackColor = false;
            this.btnTarefaIndeterminada.Click += new System.EventHandler(this.btnTarefaIndeterminada_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAtualizar.Enabled = false;
            this.btAtualizar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btAtualizar.Location = new System.Drawing.Point(458, 88);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(219, 31);
            this.btAtualizar.TabIndex = 12;
            this.btAtualizar.Text = "Atualizar Sistema";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click_1);
            // 
            // btDiretorio
            // 
            this.btDiretorio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btDiretorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btDiretorio.ForeColor = System.Drawing.Color.GhostWhite;
            this.btDiretorio.Location = new System.Drawing.Point(8, 88);
            this.btDiretorio.Name = "btDiretorio";
            this.btDiretorio.Size = new System.Drawing.Size(219, 31);
            this.btDiretorio.TabIndex = 5;
            this.btDiretorio.Text = "Criar Diretorio";
            this.btDiretorio.UseVisualStyleBackColor = false;
            this.btDiretorio.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cordia New", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(508, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "ATUALIZAÇÃO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar2);
            this.panel1.Controls.Add(this.btDiretorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btAtualizar);
            this.panel1.Controls.Add(this.btnTarefaIndeterminada);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 164);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "* Descompacte os arquivos (C:\\breakdesigner\\path\\Versao.zip)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "* Crie os diretorio caso necessario.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "* Faça download do path de atualziação.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "* Atualize o sistema.";
            // 
            // FormAtualiza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(685, 404);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAtualiza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAtualiza";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FormAtualiza_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersao;
        private System.Windows.Forms.ToolStripStatusLabel tsslSeparador2;
        private System.Windows.Forms.ToolStripStatusLabel tsslMaquinaP;
        private System.Windows.Forms.ToolStripStatusLabel tsslMaquinaR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserP;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateR;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.ComponentModel.BackgroundWorker bgWorkerIndeterminada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTarefaIndeterminada;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btDiretorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

    }
}