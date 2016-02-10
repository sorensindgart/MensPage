using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KontaktFac
/// </summary>
public class KontaktFac
{
    public int _id { get; set; }             //    fldID
    public string _adresse { get; set; }     //    fldAdresse
    public string _postnummer { get; set; }  //    fldPostnummer
    public string _by { get; set; }          //    fldBy
    public string _email { get; set; }       //    fldEmail
    public string _dag { get; set; }         //    fldDag
    public string _abningstid { get; set; }  //    fldAbningstid
    public string _lukketid { get; set; }    //    fldLukketid


    DataAccess DA = new DataAccess();

    public DataTable Kontakt()
    {
        string SQL = @"SELECT * FROM tblKontakt";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }

    public DataTable Abningstider()
    {
        string SQL = @"SELECT * FROM tblAben";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }

    public int RetKontakt()
    {
        string SQL = @"UPDATE tblKontakt
                       SET fldAdresse = @adresse, fldPostnummer = @postnummer, fldBy = @by, fldEmail = @email
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@adresse", _adresse);
        CMD.Parameters.AddWithValue("@postnummer", _postnummer);
        CMD.Parameters.AddWithValue("@by", _by);
        CMD.Parameters.AddWithValue("@email", _email);
        return DA.ModifyData(CMD);
    }                      // Edit subject

}