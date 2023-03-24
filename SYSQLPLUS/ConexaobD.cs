using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSQLPLUS
{
    public partial class ConexaoBD : Form
    {
        public ConexaoBD()
        {
            InitializeComponent();
        }

        private void lerArquivo()
        {
            string recebe = "";
            string textoConexao;
            StreamReader sr = new StreamReader(@"C:\orant\NETWORK\ADMIN\TNSNAMES.ORA");
            textoConexao = sr.ReadToEnd();

            foreach (var x in textoConexao)
            {
               // string[] colunas = textoConexao.Split(')');

                for (int b = 0; b >= textoConexao.Length; b++)
                {
                    if (x == '(')
                    {
                        MessageBox.Show(b.ToString());
                       // recebe += x.ToString();
                    }
                }

               

            }
            MessageBox.Show(recebe);


            /*
            string[] palavras = textoConexao.Split(' ');

            if (palavras.Contains("("))
            {
                MessageBox.Show("Existe!");
            }
            else
            {
                MessageBox.Show("Não existe!");
            }
          */
            /*
              string total = "";
              string total2 = "";
              int conta = 0;
              string[] colunas = textoConexao.Split(')');

              for (int x = 0; x < colunas.Length; x++)
              {
                  total += colunas[x];

                  if (total.Contains("Host = "))
                    //  MessageBox.Show("achei");
                  conta = x;
                 // break;
              }

              string[] colunas2 = total.Split('=');

              while (conta <= colunas2.Length)
              {
                  total2 += colunas2[conta];
                  //MessageBox.Show(total2);
              }
              MessageBox.Show(total2);
          
          // MessageBox.Show(total);          

          */
        }
    
    private void btConectar_Click(object sender, EventArgs e)
    {
        lerArquivo();
    }
}
}
