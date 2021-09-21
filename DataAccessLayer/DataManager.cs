using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class DataManager
{
    private SqlConnection dbConnection;
    private SqlTransaction dbTransaction;

    private static DataManager instance = new DataManager();
    public DataManager()
    {
        dbConnection = new SqlConnection();
         //var dataBaseName = ConfigurationManager.AppSettings["dataBaseName"];
         //var string_conexion = ConfigurationManager.ConnectionStrings[dataBaseName].ConnectionString;
        //dbConnection.ConnectionString = @"Data Source=DESKTOP-SFPMQMT\SQLEXPRESS;Initial Catalog=BugsExtendido;User ID=sa;Password=Blaziken99";
        dbConnection.ConnectionString = @"Data Source=MIPC\SQLEXPRESS;Initial SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=12345";
        //dbConnection.ConnectionString = @"Data Source=MIPC\SQLEXPRESS;Initial Catalog=BugsExtendido;User ID=sa;Password=sa";
        //dbConnection.ConnectionString = @"Data Source=DESKTOP-1PTMA4A;Initial Catalog=BugsExtendido;Integrated Security=True";
    }

    public void BeginTransaction()
    {
        if (dbConnection.State == ConnectionState.Open)
            dbTransaction = dbConnection.BeginTransaction();
    }

    public static DataManager GetInstance()
    {
        if (instance == null)
            instance = new DataManager();

        instance.Open();

        return instance;
    }

    public void Commit()
    {
        if (dbTransaction != null)
            dbTransaction.Commit();
    }

    public void Rollback()
    {
        if (dbTransaction != null)
            dbTransaction.Rollback();
    }
    public void Open()
    {
        if (dbConnection.State != ConnectionState.Open)
            dbConnection.Open();
    }

    public void Close()
    {
        if (dbConnection.State != ConnectionState.Closed)
            dbConnection.Close();
    }


    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo �Select�. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un objeto de tipo DataTable con el resultado de la consulta
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexi�n se produce:
    ///              a) durante la apertura de la conexi�n
    ///              b) durante la ejecuci�n del comando.
    public DataTable ConsultaSQL(string strSql)
    {
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            cmd.Connection = dbConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }

    /// Resumen:
    ///      Se utiliza para sentencias SQL del tipo �Select� con par�metros recibidos desde la interfaz
    ///      La funci�n recibe por valor una sentencia sql como string y un diccionario de objetos como par�metros
    /// Devuelve:
    ///      un objeto de tipo DataTable con el resultado de la consulta
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexi�n se produce:
    ///              a) durante la apertura de la conexi�n
    ///              b) durante la ejecuci�n del comando.
    public DataTable ConsultaSQLConParametros(string strSql, Dictionary<string, object> prs)
    {
        SqlCommand cmd = new SqlCommand();
        DataTable tabla = new DataTable();
        try
        {
            cmd.Connection = dbConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            //Agregamos a la colecci�n de par�metros del comando los filtros recibidos
            foreach (var item in prs)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }

            tabla.Load(cmd.ExecuteReader());
            return tabla;
        }
        catch (Exception ex)
        {
            throw (ex);
        }
    }

    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo �Insert/Update/Delete�. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un valor entero con el n�mero de filas afectadas por la sentencia ejecutada
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexi�n se produce:
    ///              a) durante la apertura de la conexi�n
    ///              b) durante la ejecuci�n del comando.
    public int EjecutarSQLConParametros(string strSql, Dictionary<string, object> parametros = null)
    {
        // Se utiliza para sentencias SQL del tipo �Insert/Update/Delete�

        SqlCommand cmd = new SqlCommand();

        int rtdo = 0;

        // Try Catch Finally
        // Trata de ejecutar el c�digo contenido dentro del bloque Try - Catch
        // Si hay error lo capta a trav�s de una excepci�n
        // Si no hubo error
        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucci�n a ejecutar
            cmd.CommandText = strSql;

            //Agregamos a la colecci�n de par�metros del comando los filtros recibidos
            foreach (var item in parametros)
            {
                cmd.Parameters.AddWithValue(item.Key, item.Value);
            }


            // Retorna el resultado de ejecutar el comando
            rtdo = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return rtdo;
    }

    public int EjecutarSQL(string strSql)
    {
        // Se utiliza para sentencias SQL del tipo �Insert/Update/Delete�

        SqlCommand cmd = new SqlCommand();

        int rtdo = 0;

        // Try Catch Finally
        // Trata de ejecutar el c�digo contenido dentro del bloque Try - Catch
        // Si hay error lo capta a trav�s de una excepci�n
        // Si no hubo error
        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucci�n a ejecutar
            cmd.CommandText = strSql;

            // Retorna el resultado de ejecutar el comando
            rtdo = cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return rtdo;
    }


    /// Resumen:
    ///     Se utiliza para sentencias SQL del tipo �Select�. Recibe por valor una sentencia sql como string
    /// Devuelve:
    ///      un valor entero
    /// Excepciones:
    ///      System.Data.SqlClient.SqlException:
    ///          El error de conexi�n se produce:
    ///              a) durante la apertura de la conexi�n
    ///              b) durante la ejecuci�n del comando.
    public object ConsultaSQLScalar(string strSql)
    {
        SqlCommand cmd = new SqlCommand();
        try
        {
            cmd.Connection = dbConnection;
            cmd.Transaction = dbTransaction;
            cmd.CommandType = CommandType.Text;
            // Establece la instrucci�n a ejecutar
            cmd.CommandText = strSql;
            return cmd.ExecuteScalar();
        }
        catch (SqlException ex)
        {
            throw (ex);
        }
    }

}