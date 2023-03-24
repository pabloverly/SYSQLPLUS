using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Reflection;
using System.Data.SqlClient;


namespace SYSQLPLUS
{
    public partial class SYSQLPLUS : Form
    {
        Query query = new Query();
        OracleDataAdapter DA = new OracleDataAdapter();
        DataSet DSet = new DataSet();

        SqlDataAdapter DASql = new SqlDataAdapter();
        DataSet DSetSql = new DataSet();

        TextBox tbQuery = new TextBox();
        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
        string strToCript, strToDesCript, criptografar;
        public SYSQLPLUS()
        {
            InitializeComponent();
            // tbQuery3.Visible = true;


        }
        private void btConexao_Click(object sender, EventArgs e)
        {
            ConexaoBD conexao = new ConexaoBD();
            conexao.Show();
        }
        private void btExecute_Click(object sender, EventArgs e)
        {

            carregaScripdSql();
            // lbLog.Text = dgvResultado.Rows[0].Cells[0].Value.ToString();

        }
        private void carregaScripd()
        {
            try
            {
                for (int x = 0; x <= dgvResultado.RowCount; x++)
                {
                    dgvResultado.Rows.RemoveAt(x);
                }
            }
            catch { }

            if (dgvResultado.RowCount > 0)
            {
                foreach (DataGridViewRow linha in dgvResultado.Rows)
                {
                    //  MessageBox.Show(linha.Cells[0].Value.ToString());
                    dgvResultado.Rows.Remove(linha);
                }
            }

            dgvResultado.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvResultado.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvResultado.EnableHeadersVisualStyles = false;
            dgvResultado.AllowUserToAddRows = false;

            lbLog.Text = "Executando....";
            try
            {

                DA = query.oracleDataAdapter(tbScript.Text);
                DA.Fill(DSet, "TBPACIENTE");
                dgvResultado.DataSource = DSet.Tables[0];
                //btExcel.Dock = DockStyle.Bottom;
                lbLog.Text = "Sucesso...";
                lbQtdLinhas.Text = dgvResultado.RowCount.ToString();
                lbQtdColunas.Text = dgvResultado.ColumnCount.ToString();
            }
            catch (Exception erro)
            {
                lbLog.Text = erro.Message;
                // throw erro;
            }
        }
        private void carregaScripdSql()
        {
            try
            {
                for (int x = 0; x <= dgvResultado.RowCount; x++)
                {
                    dgvResultado.Rows.RemoveAt(x);
                }
            }
            catch { }

            if (dgvResultado.RowCount > 0)
            {
                foreach (DataGridViewRow linha in dgvResultado.Rows)
                {
                    //  MessageBox.Show(linha.Cells[0].Value.ToString());
                    dgvResultado.Rows.Remove(linha);
                }
            }

            dgvResultado.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvResultado.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvResultado.EnableHeadersVisualStyles = false;
            dgvResultado.AllowUserToAddRows = false;

            lbLog.Text = "Executando....";
            try
            {

                DASql = query.SqlDataAdapter(tbScript.Text);
                DASql.Fill(DSetSql, "TBPACIENTE");
                dgvResultado.DataSource = DSetSql.Tables[0];
                //btExcel.Dock = DockStyle.Bottom;
                lbLog.Text = "Sucesso...";
                lbQtdLinhas.Text = dgvResultado.RowCount.ToString();
                lbQtdColunas.Text = dgvResultado.ColumnCount.ToString();
            }
            catch (Exception erro)
            {

                lbLog.Text = erro.Message;
                // throw erro;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgwResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btExecute_MouseHover(object sender, EventArgs e)
        {
            btExecute.FlatStyle = FlatStyle.Popup;
        }
        private void btExecute_MouseLeave(object sender, EventArgs e)
        {
            btExecute.FlatStyle = FlatStyle.Flat;
        }
        private void btCheck_Click(object sender, EventArgs e)
        {  /*          
            tbQuery.Name = "nomeDoTextBox";
            tbQuery.Height = 12;
            tbQuery.Width = 70;
            pnConteudo.Controls.Add(tbQuery);
            tbQuery.Width = 1125;
            tbQuery.Height = 209;
            tbQuery.Dock = DockStyle.Fill;
            tbQuery.ScrollBars = ScrollBars.Vertical;

            tbQuery.TabIndex = 5;
            */

            string input = "";

            ShowInputDialog(ref input);
            if (input == "hscmv2010")
            {
                btCheck.Visible = false;
                btCheckX.Visible = true;
                tbScript.Visible = true;
            }
            //dgwResultado.Dock = DockStyle.Fill;
        }
        private void btCheckX_Click(object sender, EventArgs e)
        {
            btCheck.Visible = true;
            tbScript.Visible = false;
            btCheckX.Visible = false;


        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Password";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);
            textBox.PasswordChar = '*';

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
        private void serialize()
        {
            // Serialização C#
            // Cria um arquivo para salvar os dados
            FileStream fs = new FileStream("SerializaoComplexa.Data", FileMode.Create);
            // Cria um objeto BinaryFormatter para realizar a serialização
            BinaryFormatter bf = new BinaryFormatter();
            // Usa o objeto BinaryFormatter para serializar os dados para o arquivo
            bf.Serialize(fs, btAbrirCripto.Text);
            // fecha o arquivo
            fs.Close();
            Console.WriteLine("Arquivo serializado !");
            Console.Read();
        }


        public string getMD5Hash(string input)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString();

        }

        static public string EncodeTo64(string toEncode)
        {
            byte[] toEncodeAsBytes
                  = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
            string returnValue
                  = System.Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }
        static public string DecodeFrom64(string encodedData)
        {
            byte[] encodedDataAsBytes
                = System.Convert.FromBase64String(encodedData);
            string returnValue =
               System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }

        public string SHA1Hash(string input)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string Criptografa(string cChave)
        {
            string cChaveCripto;
            Byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(cChave);
            cChaveCripto = Convert.ToBase64String(b);
            return cChaveCripto;
        }
        public string Decriptografa(string cChaveCripto)
        {
            string cChaveDecripto;
            Byte[] b = Convert.FromBase64String(cChaveCripto);
            cChaveDecripto = System.Text.ASCIIEncoding.ASCII.GetString(b);
            return cChaveDecripto;
        }

        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = tdsAlg.CreateEncryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return encrypted;

        }
        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an TripleDESCryptoServiceProvider object
            // with the specified key and IV.
            using (TripleDESCryptoServiceProvider tdsAlg = new TripleDESCryptoServiceProvider())
            {
                tdsAlg.Key = Key;
                tdsAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = tdsAlg.CreateDecryptor(tdsAlg.Key, tdsAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        public static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public static string BinaryToString(string data)
        {
            List<Byte> byteList = new List<Byte>();
            try
            {

                for (int i = 0; i < data.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
                }
            }
            catch { }
                return Encoding.ASCII.GetString(byteList.ToArray());
            
        }
        private void btAbrir_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                tbScript.Text = sr.ReadToEnd();
                sr.Close();
            }

            //TextReader tr = new StreamReader("query.txt");
            //string Script = tr.ReadToEnd();
            //tr.Dispose();
            //tbQuery3.Text = Script;
            //MessageBox.Show(Script);
        }
        private void btSalvar_Click_1(object sender, EventArgs e)
        {
            //verifica se existe algo digitado na caixa de texto
            if (string.IsNullOrEmpty(StringToBinary(EncodeTo64(tbScript.Text))))
            {
                MessageBox.Show("Informe algo na caixa de texto");
                return;
            }

            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Texto";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.bin";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Query_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".bin";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\dados";
            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;

            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                //escreve o conteúdo da caixa de texto no stream
                writer.Write(StringToBinary(EncodeTo64(tbScript.Text)));
                //fecha o escrito e o stream
                writer.Close();
            }
            else
            {
                //exibe mensagem informando que a operação foi cancelada
                MessageBox.Show("Operação cancelada");
            }

            // MessageBox.Show(MD5Crypt.Criptografar(tbQuery3.Text));           
            // MessageBox.Show(EncodeTo64(tbQuery3.Text));
            // MessageBox.Show(SHA1Hash(tbQuery3.Text));
            // MessageBox.Show(Criptografa(tbQuery3.Text));
            //serialize();   

            // escreverDiretorio(convertString_Bin(EncodeTo64(tbQuery3.Text)));

            /*    //CRIPTOGRAFAR 
                escreverDiretorio(EncodeTo64(tbQuery3.Text));
                MessageBox.Show("Criptografado.: " + leDiretorio());
                //CONVERT BINARIO
                escreverDiretorio(StringToBinary(leDiretorio()));
                MessageBox.Show("Binario.:" + leDiretorio());
                //CONVERT STRING           
                escreverDiretorio(BinaryToString(leDiretorio()));
                MessageBox.Show("String.:" + leDiretorio());
                //DESCRIPTOGRAFA
                escreverDiretorio(DecodeFrom64(leDiretorio()));
                MessageBox.Show("Descriptografado.: " + leDiretorio());
                // MessageBox.Show( "Criptografado.:" + convertBin_String(leDiretorio()));
                //MessageBox.Show(DecodeFrom64(convertBin_String(leDiretorio())));

                // MessageBox.Show(DecodeFrom64(leDiretorio()));
                */


        }
        private void picboxRest_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Normal;
            picboxMax.Visible = true;
            picboxRest.Visible = false;
        }
        private void picboxMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picboxMax.Visible = false;
            picboxRest.Visible = true;
        }
        private void picboxMin_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
            picboxMax.Visible = false;
            picboxRest.Visible = true;
        }
        private void picboxSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1); //fechar aplicacao por completo
            System.Threading.Thread.CurrentThread.Abort();
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Close();
        }
        private void btXls_Click(object sender, EventArgs e)
        {
            if (dgvResultado.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvResultado.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvResultado.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < dgvResultado.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvResultado.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dgvResultado.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void escreverDiretorio(string texto)
        {
            try
            {
                /* File.Create(@"Servidor.txt").Close();
                 using (StreamWriter writer = new StreamWriter(@"Servidor.txt", true))
                 {
                     writer.WriteLine(txtServidorIP.Text);
                 }*/

                File.WriteAllText(@"query.bin", texto);
                /*using (StreamWriter sw = File.AppendText(@"Servidor.txt"))
                {
                    sw.WriteLine(txtServidorIP.Text);               
                }*/
            }
            catch (Exception erro) { MessageBox.Show("Erro escrever local!" + erro.Message); }
        }

        private string leDiretorio()
        {
            string retorna = "";
            try
            {
                String linha = "";
                using (StreamReader sr = new StreamReader(@"query.bin"))
                {
                    // Lê linha por linha até o final do arquivo
                    while ((linha = sr.ReadLine()) != null)
                    {
                        retorna += linha;
                    }
                };
            }
            catch (Exception erro) { MessageBox.Show("Erro ler local!" + erro.Message); }
            return retorna;
        }
        private void escreverBin()
        {
            //representa o arquivo que vamos criar
            FileStream file = new FileStream(@"query.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(file);
            //grava uma string no arquivo
            bw.Write("select * from estoque");
            bw.Close();
        }
        private void lerBin()
        {
            //representa o arquivo
            FileStream file = new FileStream(@"query.bin", FileMode.Open);
            //cria o leitor do arquivo
            BinaryReader br = new BinaryReader(file);
            //lê uma string do arquivo
            MessageBox.Show(br.ReadString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                tbScript.Text = (DecodeFrom64(BinaryToString(sr.ReadToEnd())));
                sr.Close();
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brbtSalvarQuery_Click(object sender, EventArgs e)
        {
          
        }


        private void btnovo_Click(object sender, EventArgs e)
        {
            //string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            //  TabPage myTabPage = new TabPage(title);
            // tabControl1.TabPages.Add(myTabPage);



        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btServidor_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.Left;
        }

        private void btExpandir_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.None;
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.Left;
        }

        private void btArquivos_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.Left;
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.Left;
        }

        private void btNuvem_Click(object sender, EventArgs e)
        {
            pnConfig.Dock = DockStyle.Left;
        }

        private void btCodigoFonte_Click(object sender, EventArgs e)
        {
            SYSQLPLUS_Client form = new SYSQLPLUS_Client();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                tbScript.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void MudarCorTexto(RichTextBox m_rtb, string texto, Color cor)
        {
            int varStart = 0;
            int varIndex = 0;
            int varCursor = m_rtb.SelectionStart;

            m_rtb.SelectionColor = Color.White;

            while ((varIndex != -1) && (varStart < m_rtb.Text.Length))
            {
                varIndex = m_rtb.Find(texto, varStart, RichTextBoxFinds.None);
                if (varIndex != -1)
                {
                    m_rtb.SelectionColor = cor;
                    m_rtb.SelectedText = texto;

                    varStart = varIndex + texto.Length;
                }
            }
            m_rtb.SelectionStart = varCursor;
            m_rtb.SelectionColor = Color.Blue;
        }

        private void tbScript_TextChanged(object sender, EventArgs e)
        {
            if (tbScript.Text.Length > 0)
            {
                MudarCorTexto(tbScript, "select", Color.Red);
                MudarCorTexto(tbScript, "from", Color.Red);
                MudarCorTexto(tbScript, "*", Color.Red);
            }
        }

        private void EscreverNoArquivo()
        {
            //ler o arquivo
            FileStream FluxoDeAquivo = new FileStream(@"query.txt", FileMode.Open);
            BinaryReader LeitorDeFluxo = new BinaryReader(FluxoDeAquivo);

            // Cria array de bytes com dados do arquivo
            byte[] dados = LeitorDeFluxo.ReadBytes(Convert.ToInt32(FluxoDeAquivo.Length));

            //Cria array de bytes com suas informacao
            byte[] minhaInformacao = ASCIIEncoding.ASCII.GetBytes("visual studio");

            //cria array de byte com tamanho do de dados com o de informacao.
            //Por que suas informacao sera adicionada depois dos bytes do arquivos
            byte[] buffer = new byte[dados.Length + minhaInformacao.Length];

            //Copia dados para seu array
            dados.CopyTo(buffer, 0);

            //Copia suas informacao para seu  array a depois da posicao dos dados
            minhaInformacao.CopyTo(buffer, dados.Length);

            //crio executavel já 
            FileStream FS = new FileStream(@"1.bin", FileMode.Create);
            BinaryWriter escrita = new BinaryWriter(FS);

            //salvo no disco
            escrita.Write(buffer);
            escrita.Close();
            LeitorDeFluxo.Close();
            FluxoDeAquivo.Close();
            FS.Close();
        }

        private string lerArquivo()
        {
            //le o executavel com as informacao que foi inserida
            FileStream FluxoDeArquivo = new FileStream(@"E:\JSON.txt", FileMode.Open);
            BinaryReader br = new BinaryReader(FluxoDeArquivo);

            //cria array com os dados do executavel
            byte[] dados = br.ReadBytes(Convert.ToInt32(FluxoDeArquivo.Length));

            //esse array com 13 posicoes, é por que as informacoes tem que ter tamanho fixo
            byte[] informacao = new byte[13];

            //var pegar os bytes após ter acabado a posicao do arquivo e inicia a informacao
            int Posicao = dados.Length - 13;

            //pega posicao por posicao e coloca no array
            for (int i = 0; i < informacao.Length; i++)
            {
                var info = dados.GetValue(Posicao + i);
                informacao.SetValue(info, i);
            }

            //recupero a informacao no final
            string mensagem = Encoding.ASCII.GetString(informacao);

            FluxoDeArquivo.Close();
            br.Close();
            return mensagem;
        }
    }
}
