using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPBBL;
using System.Data;
using System.Data.SqlClient;

namespace DPDAL
{
    public class CategoryDAOIMP:ICrudDAO<Category>
    {
        SqlConnection con = DBconnection.con;
        #region Create cateory
        public bool CreateData(Category obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Categories (CategoryName,Description,Picture) VALUES (@catname,@description,@pic)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);

            cmd.Parameters.AddWithValue("@catname", obj.CategoryName);
            cmd.Parameters.AddWithValue("@description", obj.Description);
            SqlParameter pr = cmd.Parameters.AddWithValue("@pic", SqlDbType.Binary);
            pr.Value = obj.Picture;
            pr.Size = obj.Picture.Length;



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
        #endregion

        #region  Update category
        public bool UpdateData(Category obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Categories  SET  CategoryName=@catname,Description=@description,Picture=@pic  WHERE CategoryID=@catID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@catID", obj.CategoryID);
            cmd.Parameters.AddWithValue("@catname", obj.CategoryName);
            cmd.Parameters.AddWithValue("@description", obj.Description);
            SqlParameter pr = cmd.Parameters.AddWithValue("@pic", SqlDbType.Binary);
            pr.Value = obj.Picture;
            pr.Size = obj.Picture.Length;

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
        #endregion q
        #region Getallcaegory
        public DataSet GetAllData()
        {

            string sqlallemp = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "allcat");
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
        #endregion
        #region get by id
        public DataSet GetDataByID(Category Id)
        {
            string sqlSearch = "SELECT * FROM Categories WHERE CategoryID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Id.CategoryID);
            try
            {
                con.Open();
                adp.Fill(ds, "catid");
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
        #endregion
        #region Get cat by name
        public DataSet GetDataByName(Category Name)
        {
            string sqlSearch = "SELECT * FROM Categories WHERE CategoryName=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Name.CategoryName);
            try
            {
                con.Open();
                adp.Fill(ds, "catname");
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
        #endregion
        #region delet Category
        public bool DeleteData(Category Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Categories WHERE CategoryID=@catID ";

            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@catID", Id.CategoryID);

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
        #endregion

       

      

        
    }
}
