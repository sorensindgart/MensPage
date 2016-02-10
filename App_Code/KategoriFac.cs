using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for KategoriFac
/// </summary>
public class KategoriFac
{
    public int _id { get; set; }            //    fldKatID
    public string _kat { get; set; }        //    fldKategori
    public int _parent { get; set; }        //    fldParent

    DataAccess DA = new DataAccess();

    public DataTable HentAlleKategorier()
    {
        string SQL = @"SELECT * FROM tblKategorier WHERE fldParent = 0";
        SqlCommand CMD = new SqlCommand(SQL);
        return DA.GetData(CMD);
    }

    public DataTable HentUnderKategorier(int katID)
    {
        string SQL = @"SELECT *
                       FROM tblKategorier
                       WHERE fldParent = @id";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@id", katID);
        return DA.GetData(CMD);
    }

    public DataTable HentOverkategoriUdFraProdukt(int produktID)
    {
        string SQL = @"SELECT * FROM tblKategorier WHERE fldKatID =
	                    (
	                    SELECT fldParent FROM tblKategorier WHERE fldKatID = 
		                    (
			                    SELECT fldKatID_fk FROM tblProdukter WHERE fldID = @produktid
		                    )
                        )";
        SqlCommand CMD = new SqlCommand(SQL);
        CMD.Parameters.AddWithValue("@produktid", produktID);
        return DA.GetData(CMD);
    }

}