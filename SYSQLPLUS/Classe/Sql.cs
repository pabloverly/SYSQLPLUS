using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SYSQLPLUS
{
    public class Sql
    {
        string textoConexaoLocal = "Data Source=192.168.1.6;Initial Catalog=TESTE;User ID=sa;Password=Pv020502@";

        //string textoConexaoLocal = "Data Source=10.0.70.101;Initial Catalog=TELEMATICA;User ID=sa;Password=Hscmv@2016";
        // string textoConexaoLocal = "Data Source=192.168.70.12;Initial Catalog=emescam;User Id=usuario;Password=12345678";
        public String banco()
        {
            // string sr = "Data Source=10.0.70.101;Initial Catalog=TELEMATICA;User ID=sa;Password=Hscmv@2016";
            // string sr = "Data Source=10.0.70.101;Initial Catalog=TELEMATICA_SIMULACAO;User ID=sa;Password=Hscmv@2016";
            //  string sr = "Data Source=192.168.70.12;Initial Catalog=emescam;User Id=usuario;Password=12345678";
            string sr = " Data Source = 192.168.1.6; Initial Catalog=TESTE; User ID = sa; Password = Pv020502@";
            return sr;
        }      
        public SqlConnection conn = new SqlConnection();    

        public void AbreConexao()
        {
            conn.ConnectionString = "" + textoConexaoLocal + ""; 
            conn.Open();
        }
        public SqlConnection RetornaConexao()
        {
            return conn;
        }
        public void FechaConexao()
        {
            conn.Close();
        }
    }    
}

