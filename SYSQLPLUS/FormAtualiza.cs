using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace SYSQLPLUS
{
    public partial class FormAtualiza : Form
    {
        public FormAtualiza()
        {
            InitializeComponent();
            infRodape();
          
        }
        protected void excluir()
        {
            

            // Delete a directory. Must be writable or empty.
            try
            {
                System.IO.Directory.Delete(@"E:\breakdesigner\");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            // Delete a directory and all subdirectories with Directory static method...
            if (System.IO.Directory.Exists(@"E:\breakdesigner\"))
            {
                try
                {
                    System.IO.Directory.Delete(@"E:\breakdesigner\", true);
                }

                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            // ...or with DirectoryInfo instance method.
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"E:\breakdesigner\");
            // Delete this dir and all subdirs.
            try
            {
                di.Delete(true);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        protected void infRodape()
        {
            tsslMaquinaR.Text = System.Windows.Forms.SystemInformation.ComputerName;
            tsslDateR.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToShortTimeString();
            tsslUserR.Text = System.Windows.Forms.SystemInformation.UserName;
            //tsslUserR.Text =System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(4); 
            //tsslUserR.Text = System.Environment.UserName; ;

        }
        private void TarefaLonga(int p)
        {
            for (int i = 0; i <= 10; i++)
            {
                // faz a thread dormir por "p" milissegundos a cada passagem do loop
                Thread.Sleep(p);
                label2.BeginInvoke(
                   new Action(() =>
                   {
                       label2.Text = "Tarefa: " + i.ToString() + " comcluída";
                   }
                ));

            }
        }
        protected void downArquivos()
        {
            try
            {
                ///////abaixar diretamente
                // DowVersao();

                //////download no diretorio////
                string urlArquivo = "http://www.breakdesigner.com/Arquivos/SisBreak32bit/path/Versao.zip";
                string caminhoArquivo = @"E:\breakdesigner\path\Versao.zip";
                System.Net.WebClient client = new System.Net.WebClient();
                client.DownloadFile(urlArquivo, caminhoArquivo);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
            }
        }
        protected void extrair()
        {
            string caminho = @"E:\breakdesigner\path\Versao.zip";
            string destino = @"E:\breakdesigner\";
            try
            {
                ZipZap.ExtrairArquivoZip(caminho, destino);
                MessageBox.Show(" A arquivo\n\n " + caminho +
                                "foi extraído com sucesso na pasta \n\n" + destino);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao extrair o arquivo ZIP.\n\n " + ex.Message);
            }
        }
        public void DowVersao()
        {
            string app = @"C:\Program Files\Internet Explorer\iexplore.exe";
            string param = "http://www.breakdesigner.com/Arquivos/SisBreak32bit/path/SisBreak.application";
            System.Diagnostics.Process process = System.Diagnostics.Process.Start(param);
            //System.Diagnostics.Process process = System.Diagnostics.Process.Start(app, param);
        }
        protected void processar()
        {
            try
            {
                btnTarefaIndeterminada.Enabled = false;
                bgWorkerIndeterminada.RunWorkerAsync();

                //define a progressBar para Marquee
                progressBar2.Style = ProgressBarStyle.Marquee;
                progressBar2.MarqueeAnimationSpeed = 5;

                //informa que a tarefa esta sendo executada.
                label1.Text = "Processando...";
                btAtualizar.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no Download do Arquivo!");
            }
        }

        private void FormAtualiza_Load(object sender, EventArgs e)
        {

        }        
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            btnTarefaIndeterminada.Enabled = true;
            try
            {
                excluir();
                Directory.CreateDirectory(@"C:\temp\");
                Directory.CreateDirectory(@"E:\breakdesigner");
                Directory.CreateDirectory(@"E:\breakdesigner\path");
                btnTarefaIndeterminada.Enabled = true;
                MessageBox.Show("Diretório Criado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Criar o Diretório");
            }
        }              
         
        private void btnTarefaIndeterminada_Click(object sender, EventArgs e)
        {
            btAtualizar.Enabled = true;
            //desabilita os botões enquanto a tarefa é executada.
            try
            {
                btnTarefaIndeterminada.Enabled = false;
                bgWorkerIndeterminada.RunWorkerAsync();

                //define a progressBar para Marquee
                progressBar2.Style = ProgressBarStyle.Marquee;
                progressBar2.MarqueeAnimationSpeed = 5;

                //informa que a tarefa esta sendo executada.
                label1.Text = "Processando...";
                btAtualizar.Enabled = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no Download do Arquivo!");
            }
        }
        private void bgWorkerIndeterminada_DoWork(object sender, DoWorkEventArgs e)
        {
            //executa a tarefa a primeira vez
            downArquivos(); //  TarefaLonga(100);
            extrair();
            //Verifica se houve uma requisição para cancelar a operação.
            if (bgWorkerIndeterminada.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;
            }

            //executa a tarefa pela segunda vez
            downArquivos();  //   TarefaLonga(500);
            if (bgWorkerIndeterminada.CancellationPending)
            {
                //se sim, define a propriedade Cancel para true
                //para que o evento WorkerCompleted saiba que a tarefa foi cancelada.
                e.Cancel = true;
                return;
            }
        }
        private void bgWorkerIndeterminada_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Caso cancelado...
            if (e.Cancelled)
            {
                // reconfigura a progressbar para o padrao.
                progressBar2.MarqueeAnimationSpeed = 0;
                progressBar2.Style = ProgressBarStyle.Blocks;
                progressBar2.Value = 0;

                //caso a operação seja cancelada, informa ao usuario.
                label2.Text = "Operação Cancelada pelo Usuário!";
                             
                //limpa a label
                label1.Text = string.Empty;
            }
            else if (e.Error != null)
            {
                //informa ao usuario do acontecimento de algum erro.
                label2.Text = "Aconteceu um erro durante a execução do processo!";

                // reconfigura a progressbar para o padrao.
                progressBar2.MarqueeAnimationSpeed = 0;
                progressBar2.Style = ProgressBarStyle.Blocks;
                progressBar2.Value = 0;
            }
            else
            {
                //informa que a tarefa foi concluida com sucesso.
                label2.Text = "Tarefa Concluida com sucesso!";

                //Carrega todo progressbar.
                progressBar2.MarqueeAnimationSpeed = 0;
                progressBar2.Style = ProgressBarStyle.Blocks;
                progressBar2.Value = 100;
                label1.Text = progressBar2.Value.ToString() + "%";
            }
            //habilita os botões.

            btnTarefaIndeterminada.Enabled = true;
        }
            

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string app = @"E:\breakdesigner\SisBreak.application";              
                System.Diagnostics.Process process = System.Diagnostics.Process.Start(app);
                MessageBox.Show("Executando Atualizacao!");
                Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro no Download do Arquivo!");
            }
        }

       
    }
}
