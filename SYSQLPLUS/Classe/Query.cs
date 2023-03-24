using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.IO;
using System.Data.Sql;
using System.Data.OracleClient;
using System.Data.SqlClient;

namespace SYSQLPLUS
{
    public class Query
    {        
        OracleConnection conexaoOracle = null;
        Conexao objConn = new Conexao();
        string textoConexao;

        public OracleConnection conn = new OracleConnection();
        public OracleDataAdapter oracleDataAdapter(string query)
        {
            StreamReader banco = objConn.banco();
            textoConexao = banco.ReadToEnd();
            OracleDataAdapter da_MargContrib = new OracleDataAdapter();
            conn = new OracleConnection(textoConexao);
            OracleCommand sql = new OracleCommand(query, conn);
            da_MargContrib.SelectCommand = sql;
            return da_MargContrib;
        }
        public DataTable datatable(string query)
        {
            
            try
            {              


                conexaoOracle = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.30.11)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=MVPROD))); User Id=dbamv; Password=promv2010");
              

                OracleCommand sql = new OracleCommand("select * from estoque", conexaoOracle);
                OracleDataAdapter dataAdapter = new OracleDataAdapter();
                dataAdapter.SelectCommand = sql;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        SqlConnection conexaoSql = null;
        Sql objConnSql = new Sql();
        string textoConexaoSql;

        public SqlConnection connSql = new SqlConnection();
        public SqlDataAdapter SqlDataAdapter(string query)
        {
            string textoConexao = objConnSql.banco();            
            SqlDataAdapter da_MargContrib = new SqlDataAdapter();
            connSql = new SqlConnection(textoConexao);
            SqlCommand sql = new SqlCommand(query, connSql);
            da_MargContrib.SelectCommand = sql;
            return da_MargContrib;
        }
        public DataTable datatableSql(string query)
        {

            try
            {


                conexaoSql = new SqlConnection("Data Source=192.168.1.6;Initial Catalog=TESTE;User ID=sa;Password=Pv020502@");


                SqlCommand sql = new SqlCommand("select * from estoque", conexaoSql);
                SqlDataAdapter dataAdapterSql = new SqlDataAdapter();
                dataAdapterSql.SelectCommand = sql;
                DataTable dataTableSql = new DataTable();
                dataAdapterSql.Fill(dataTableSql);
                return dataTableSql;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}