using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    // ConnectionString - "name" fra web.config:
    string Conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

    /// <summary>
    /// Returnerer data fra databasen
    /// </summary>
    /// <param name="CMD">Send SQL smed som skal udføres</param>
    /// <returns>Retunerer en DataTable med de valgte/selectede data</returns>

    public DataTable GetData(SqlCommand CMD)
    { //ModifyData kan bruges istedet for"GetData"

        // Connect til databasen og tag CMD ("SQL") med
        SqlConnection objConn = new SqlConnection(Conn);
        CMD.Connection = objConn;

        SqlDataAdapter objDA = new SqlDataAdapter();
        objDA.SelectCommand = CMD;

        // Modtag resultatet
        DataTable dt = new DataTable();
        objDA.Fill(dt);

        // Og retuner det til "spørgeren" (request'et)
        return dt;
    }

    /// <summary>
    /// Til at ændre/modify (oprette, rette, slette) data i databasen
    /// </summary>
    /// <param name="CMD">Send SQL-sætning med som skal udføres.</param>

    public int ModifyData(SqlCommand CMD)
    {
        SqlConnection objConn = new SqlConnection(Conn);
        int rowsaffected = 0;

        try
        {
            CMD.Connection = objConn;
            objConn.Open();
            // Udfør modify-SQL'en og grib antal oprettede-rettede-slettede rækker
            rowsaffected = CMD.ExecuteNonQuery();
        }
        finally
        {
            objConn.Close();
        }
        // Retuner antal oprettede-rettede-slettede rækker
        return rowsaffected;
    }
}