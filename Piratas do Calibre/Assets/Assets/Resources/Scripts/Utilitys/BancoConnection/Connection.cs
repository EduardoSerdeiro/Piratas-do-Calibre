using UnityEngine;
using System.Collections;
using MySql.Data.MySqlClient;

public class Connection : MonoBehaviour {

    public MySqlParameter par;
    public MySqlCommand command;
    public MySqlDataReader reader;

    public MySqlConnection Conexao()
    {
         //private string StrConn = "Server= 127.0.0.1; Port=3306; Database=PdC; Uid= root; Pwd=admin";
        string StrConnection = "Server= 127.0.0.1; Port=3306; Database=PdC; User id= root; Password=admin; Pooling = false;";
         MySqlConnection conexao = new MySqlConnection(StrConnection);
         conexao.Open();

         return conexao;
    }

    public bool Logar(string nickname, string senha)
    {
        Conexao();
        bool logado = false;
        string sql = "select id, nickname, senha from Usuario where nickname= @nickname and senha= @senha";
        command = new MySqlCommand(sql, Conexao());

        par = new MySqlParameter("@nickname", nickname);
        par.MySqlDbType = MySqlDbType.VarChar;
        command.Parameters.Add(par);

        par = new MySqlParameter("@senha", senha);
        par.MySqlDbType = MySqlDbType.VarChar;
        command.Parameters.Add(par);

        reader = command.ExecuteReader();

        if (reader.Read())
        {
            logado = true;
            
        }
        return logado;
       
        
       // command = new System.Data.SqlClient.SqlCommand(sql, conexão());
    }
}
