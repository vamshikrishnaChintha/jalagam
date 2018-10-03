﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Logic
/// </summary>
public class Logic
{
    #region " Global Variables"
    //Sql Connection variable
    SqlConnection con;
    #endregion

    public Logic()
    {
        try
        {
            //Create Connection object
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["JalagamConnectionString"].ConnectionString);
        }
        catch
        {
            //Exception Handled

        }
    }
    public int fnCreateNewPhotoGallery(string GalleryName, string GalleryDescription, DateTime GalleryCreatedDate, out int MaxGalleryId)
    {
        int ReturnValue;
        SqlCommand cmd = new SqlCommand("usp_CreateNewGallery", con);

        cmd.CommandType = CommandType.StoredProcedure;

        SqlParameter OutputValue = new SqlParameter();
        OutputValue.ParameterName = "@MaxGalleryId";
        OutputValue.SqlDbType = SqlDbType.Int;
        OutputValue.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(OutputValue);

        cmd.Parameters.AddWithValue("@GalleryName", GalleryName);
        cmd.Parameters.AddWithValue("@GalleryDescription", GalleryDescription);
        cmd.Parameters.AddWithValue("@GalleryCreatedDate", GalleryCreatedDate);

        con.Open();
        cmd.ExecuteNonQuery();
        ReturnValue = Convert.ToInt32(OutputValue.Value);
        con.Close();

        MaxGalleryId = Convert.ToInt32(OutputValue.Value);
        return ReturnValue;
    }

    public DataSet fnLoadGallery(int ProductId)
    {
        DataSet dsLoadGallery = new DataSet();
        try
        {
            SqlDataAdapter daLoadGallery = new SqlDataAdapter(" select Id from Product_Master where Id='" + ProductId + "' ", con);
            daLoadGallery.Fill(dsLoadGallery, "LoadGallery");
        }
        catch (Exception ex)
        {
            //Exception Handled
            Console.WriteLine(ex.Message);
        }
        finally
        {

        }
        return dsLoadGallery;
    }


    public DataSet fnLoadGalleryAcc(int AccId)
    {
        DataSet dsLoadGallery = new DataSet();
        try
        {
            SqlDataAdapter daLoadGallery = new SqlDataAdapter(" select Id from Accessories_Master where Id='" + AccId + "' ", con);
            daLoadGallery.Fill(dsLoadGallery, "LoadGallery");
        }
        catch (Exception ex)
        {
            //Exception Handled
            Console.WriteLine(ex.Message);
        }
        finally
        {

        }
        return dsLoadGallery;
    }


}