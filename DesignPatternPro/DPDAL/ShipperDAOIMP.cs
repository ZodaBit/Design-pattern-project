using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DPBBL;

namespace DPDAL
{
    public class ShipperDAOIMP:ICrudDAO<Shipper>
    {
        SqlConnection con = DBconnection.con;
       

        public bool CreateData(Shipper obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Shippers (CompanyName,Phone) VALUES (@companyName,@phone)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);

            cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
            cmd.Parameters.AddWithValue("@phone", obj.Phone);

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

        public bool UpdateData(Shipper obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Shippers  SET  CompanyName=@companyName,Phone=@phone  WHERE ShipperID=@shipperID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@shipperID", obj.ShipperID);
            cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
            cmd.Parameters.AddWithValue("@phone", obj.Phone);

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
            string sqlallemp = "SELECT * FROM Shippers";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "ship");
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

        public DataSet GetDataByID(Shipper Id)
        {
            string sqlSearch = "SELECT * FROM Shippers WHERE ShipperID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Id.ShipperID);
            try
            {
                con.Open();
                adp.Fill(ds, "shpid");
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

        public DataSet GetDataByName(Shipper Name)
        {
            string sqlSearch = "SELECT * FROM Shippers  WHERE CompanyName=@Cname";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@Cname", Name.CompanyName);
            try
            {
                con.Open();
                adp.Fill(ds, "shipname");
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

        public bool DeleteData(Shipper Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Shippers WHERE ShipperID=@catID";

            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@catID", Id.ShipperID);

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
