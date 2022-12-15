using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

public static class MySQLAction
{
    private static MySqlConnection startConn()
    {
        const string connStr = "server=localhost;user=root;database=niver;port=3306;password=C0r@g3m!"
        MySqlConnection conn = mew MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Conectando com o Base de Dados...");
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
        return conn;
    }

    public static void addNiver(string nome, string sobrenome, DateTime niver)
    {
        var conn = startConn();
        string sqlCmd = "INSERT INTO pessoa (nome, sobrenome, nasc) VALUES (" + nome + ", " + sobrenome + ", " + niver + ");"
        try
        {
            MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
        finally
        {
            rdr.Close();
            con.Close();
        }
    }

    public static void editNiver(int id, string nome, string sobrenome, DateTime niver)
    {
        var conn = startConn();
        string sqlCmd = "UPDATE pessoa\nSET name = " + name + ", sobrenome = " + sobrenome + ", nasc = " + niver + "\n WHERE id = " + id + ";";
        try
        {
            MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
        finally
        {
            rdr.Close();
            con.Close();
        }
    }

    public static void rmNiver(int id)
    {
        var conn = startConn();
        string sqlCmd = "DELETE FROM pessoa WHERE id = " + id + ";";
        try
        {
            MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
        finally
        {
            rdr.Close();
            con.Close();
        }
    }

    public static MySqlDataReader selctAllNiver()
    {
        var conn = startConn();
        string sqlCmd = "SELECT * FROM pessoa;";
        try
        {
            MySqlCommand cmd = new MySqlCommand(sqlCmd, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
        finally
        {
            con.Close();
        }
        return rdr;
    }
}