using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DPDTO;
using DPDTO;

namespace DPDAL
{
    public class RegionDAOIMP:ICrudDAO<MyRegion>
    {
        SqlConnection con = DBconnection.con;

   
    
        public bool CreateData(MyRegion obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Region (RegionID,RegionDescription) VALUES (@regionID,@regionDescription)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);

            cmd.Parameters.AddWithValue("@regionID", obj.RegionID);
            cmd.Parameters.AddWithValue("@regionDescription", obj.RegionDescription);

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

        public bool UpdateData(MyRegion obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Region  SET  RegionDescription=@regionDescription  WHERE RegionID=@regionID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@regionID", obj.RegionID);
            cmd.Parameters.AddWithValue("@regionDescription", obj.RegionDescription);


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
            string sqlallemp = "SELECT * FROM Region";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "reg");
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

        public DataSet GetDataByID(MyRegion Id)
        {
            string sqlSearch = "SELECT * FROM Region WHERE RegionID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Id.RegionID);
            try
            {
                con.Open();
                adp.Fill(ds, "reid");
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

        public DataSet GetDataByName(MyRegion Name)
        {
            throw new NotImplementedException();
        }

        public bool DeleteData(MyRegion Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Region WHERE RegionID=@catID";

            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@catID", Id.RegionID);

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
