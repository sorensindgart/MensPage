using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProduktFac
/// </summary>
public class ProduktFac
{
    public int _id { get; set; }                //fldID
    public string _overskrift { get; set; }     //fldOverskrift
    public string _teaser { get; set; }         //fldTeaser
    public string _tekst { get; set; }          //fldTekst
    public string _pris { get; set; }           //fldPris
    public string _image { get; set; }          //fldBillede
    public int _katID { get; set; }             //fldKatID_fk

    DataAccess DA = new DataAccess();

    public DataTable AlleProdukter()
    {
        string SQL = @"SELECT *
                       FROM tblProdukter";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }         // Få alle produkter

    public DataTable ProduktFraID()
    {
        string SQL = @"SELECT * 
                       FROM tblProdukter 
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.GetData(CMD);
    }          // Få produkt ud fra ID

    public DataTable RandomProdukt()
    {
        string SQL = @"SELECT TOP 1 *
                     FROM tblProdukter
                     ORDER BY NEWID() DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }        // Få random produkt

    public DataTable SenesteProdukt()
    {
        string SQL = @"SELECT TOP 1 *
                     FROM tblProdukter
                     ORDER BY fldID DESC";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }        // Få random produkt

    public int OpretProdukt()
    {
        string SQL = @"INSERT INTO tblProdukter (fldOverskrift, fldTeaser, fldTekst, fldPris, fldBillede, fldKatID_fk)
                       VALUES (@overskrift, @teaser, @tekst, @pris, @img, @katid)";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@teaser", _teaser);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@pris", _pris);
        CMD.Parameters.AddWithValue("@img", _image);
        CMD.Parameters.AddWithValue("@katid", _katID);
        return DA.ModifyData(CMD);
    }                // Opret nyt produkt

    public int SletProdukt()
    {
        string SQL = @"DELETE FROM tblProdukter WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        return DA.ModifyData(CMD);
    }                 // Slet produkt

    public int RetProdukt()
    {
        string SQL = @"UPDATE tblProdukter 
                       SET fldOverskrift = @overskrift, fldTeaser = @teaser, fldTekst = @tekst, fldPris = @pris, fldBillede = @img, fldKatID_fk = @katid 
                       WHERE fldID = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", _id);
        CMD.Parameters.AddWithValue("@overskrift", _overskrift);
        CMD.Parameters.AddWithValue("@teaser", _teaser);
        CMD.Parameters.AddWithValue("@tekst", _tekst);
        CMD.Parameters.AddWithValue("@pris", _pris);
        CMD.Parameters.AddWithValue("@img", _image);
        CMD.Parameters.AddWithValue("@katid", _katID);
        return DA.ModifyData(CMD);
    }                  // Edit subject

}