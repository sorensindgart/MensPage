using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ForsideFac
/// </summary>
public class ForsideFac
{
    public int _id { get; set; }            //    fldID
    public string _overskrift { get; set; } //    fldOverskrift
    public string _tekst { get; set; }      //    fldTekst
    public string _image { get; set; }      //    fldBillede

    DataAccess DA = new DataAccess();

    public DataTable AlleForsider()
    {
        string SQL = @"SELECT *
                       FROM tblForside";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }         // Få alle Forsider

    public DataTable ForsideFraID()
    {
        string SQL = @"SELECT * 
                       FROM tblForside
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.GetData(CMD);
    }          // Få Forside ud fra ID

    public DataTable SenesteForside()
    {
        string SQL = @"SELECT TOP 1 *
                     FROM tblForside
                     ORDER BY NEWID() DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }        // Få seneste Forside

    public int OpretForside()
    {
        string SQL = @"INSERT INTO tblForside (fldOverskrift, fldTekst, fldBillede)
                       VALUES (@overskrift, @tekst, @img)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@img", _image);
        return DA.ModifyData(CMD);
    }                // Opret ny Forside

    public int SletForside()
    {
        string SQL = @"DELETE FROM tblForside WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.ModifyData(CMD);
    }                 // Slet Forside

    public int RetForside()
    {
        string SQL = @"UPDATE tblForside
                       SET fldOverskrift = @overskrift, fldTekst = @tekst, fldBillede = @img
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@img", _image);
        return DA.ModifyData(CMD);
    }                  // Rediger Forside
}