using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSystem
{
    class Bd
    {
        //metodo para estabelecer a conexão com o servidor
        public static OleDbConnection Conexao()
        {
            String conexao = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\Bd\BdPastelaria.accdb";
            OleDbConnection link = new OleDbConnection(conexao);
            return link;
        }

        public static string Retornar(String Comando)
        {
            OleDbCommand comando = new OleDbCommand(Comando, Conexao());
            comando.Connection.Open();
            string valor = comando.ExecuteScalar().ToString();
            comando.Connection.Close();
            return valor;
        }

        public static DataTable Executar(String Comando)
        {
            OleDbCommand Cmd = new OleDbCommand(Comando, Conexao());
            OleDbDataAdapter dados = new OleDbDataAdapter(Cmd);
            DataTable tb = new DataTable();
            dados.Fill(tb);
            return tb;
        }
    }
}
