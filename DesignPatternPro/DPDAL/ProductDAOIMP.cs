using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DPDTO;

namespace DPDAL
{
   public class ProductDAOIMP:ICrudDAO<Product>
    {
        SqlConnection con = DBconnection.con;

  

        public bool CreateData(Product obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)" +
                "VALUES (@productName,@supplierID,@categoryID,@quantityPerUnit,@unitPrice,@unitsInStock,@unitsOnOrder,@recorderLevel,@discontinued)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);

            cmd.Parameters.AddWithValue("@productName", obj.ProductName);
            cmd.Parameters.AddWithValue("@supplierID", obj.SupplierID);
            cmd.Parameters.AddWithValue("@categoryID", obj.CategoryID);
            cmd.Parameters.AddWithValue("@quantityPerUnit", obj.QuantityPerUnit);
            cmd.Parameters.AddWithValue("@unitPrice", obj.UnitPrice);
            cmd.Parameters.AddWithValue("@unitsInStock", obj.UnitsInStock);
            cmd.Parameters.AddWithValue("@unitsOnOrder", obj.UnitsOnOrder);
            cmd.Parameters.AddWithValue("@recorderLevel", obj.RecorderLevel);
            cmd.Parameters.AddWithValue("@discontinued", obj.Discontinued);


            try
            {
                con.Open();
                inserted = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            if (inserted > 0)     //inserte is SuccesFull
                return true;
            else                 //inserte Failled
                return false;
        }

        public bool UpdateData(Product obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Products  SET  ProductName=@productName,SupplierID=@supplierID,CategoryID=@categoryID,QuantityPerUnit=@quantityPerUnit,UnitPrice=@unitPrice,UnitsInStock=@unitsInStock,UnitsOnOrder=@unitsOnOrder,ReorderLevel=@recorderLevel,Discontinued=@discontinued WHERE ProductID=@productID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@productID", obj.ProductID);
            cmd.Parameters.AddWithValue("@productName", obj.ProductName);
            cmd.Parameters.AddWithValue("@supplierID", obj.SupplierID);
            cmd.Parameters.AddWithValue("@categoryID", obj.CategoryID);
            cmd.Parameters.AddWithValue("@quantityPerUnit", obj.QuantityPerUnit);
            cmd.Parameters.AddWithValue("@unitPrice", obj.UnitPrice);
            cmd.Parameters.AddWithValue("@unitsInStock", obj.UnitsInStock);
            cmd.Parameters.AddWithValue("@unitsOnOrder", obj.UnitsOnOrder);
            cmd.Parameters.AddWithValue("@recorderLevel", obj.RecorderLevel);
            cmd.Parameters.AddWithValue("@discontinued", obj.Discontinued);


            try
            {
                con.Open();
                Updated = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            if (Updated > 0)     //Update is SuccesFull
                return true;
            else                 //Update Failled
                return false;
        }

        public DataSet GetAllData()
        {
            string sqlallemp = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "pro");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }

        public DataSet GetDataByID(Product Id)
        {
            string sqlSearch = "SELECT * FROM Products WHERE ProductID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Id.ProductID);
            try
            {
                con.Open();
                adp.Fill(ds, "proid");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }
        
        public DataSet GetDataByName(Product Name)
        {
            string sqlSearch = "SELECT * FROM Products WHERE ProductName=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Name.ProductName);
            try
            {
                con.Open();
                adp.Fill(ds, "proname");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ds; // retun search result
        }

        public bool DeleteData(Product Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Products WHERE ProductID=@catID";

            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@catID", Id.ProductID);

            try
            {
                con.Open();
                deleted = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            if (deleted > 0)     //delete is SuccesFull
                return true;
            else                 //delete Failled
                return false;
        }
    }
}
