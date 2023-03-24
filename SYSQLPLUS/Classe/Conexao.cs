using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using System.IO;

namespace SYSQLPLUS
{
    public class Conexao
    {
        public OracleConnection conn = new OracleConnection();

        public StreamReader banco()
        {
            StreamReader sr = new StreamReader(@"C:\orant\NETWORK\ADMIN\dbamv.txt");
            return sr;
        }
        public void AbreConexao()
        {
           // conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.1.105)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=MVTRN))); User Id=dbamv; Password=dbamv";
             conn.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.70.52)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=MVPROD))); User Id=dbamv; Password=hscmv2010";
                conn.Open();                        
        }

        public OracleConnection RetornaConexao()
        {
            return conn;
        }

        public void FechaConexao()
        {
            conn.Close();
        } 
    }  
}



