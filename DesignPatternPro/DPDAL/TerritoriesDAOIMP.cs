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
   public class TerritoriesDAOIMP:ICrudDAO<Territories>
    {
        SqlConnection con = DBconnection.con;
       
      

        public bool CreateData(Territories obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Territories (TerritoryID,TerritoryDescription, RegionID) VALUES (@territoryID,@territoryDescription, @regionID)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);
            cmd.Parameters.AddWithValue("@territoryID", obj.TerritoryID);
            cmd.Parameters.AddWithValue("@territoryDescription", obj.TerritoryDescription);
            cmd.Parameters.AddWithValue("@regionID", obj.RegionID);

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

        public bool UpdateData(Territories obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Territories  SET  TerritoryDescription=@territoryDescription, RegionID=@regionID  WHERE TerritoryID=@teritoryID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@teritoryID", obj.TerritoryID);
            cmd.Parameters.AddWithValue("@territoryDescription", obj.TerritoryDescription);
            cmd.Parameters.AddWithValue("@regionID", obj.RegionID);

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
            string sqlallemp = "SELECT * FROM Territories";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "Ter");
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

        public DataSet GetDataByID(Territories Id)
        {
            string sqlSearch = "SELECT * FROM Territories WHERE TerritoryID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Id.TerritoryID);
            try
            {
                con.Open();
                adp.Fill(ds, "terid");
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

        public DataSet GetDataByName(Territories Name)
        {
            string sqlSearch = "SELECT * FROM Territories WHERE RegionID=@catID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@catID", Name.RegionID);
            try
            {
                con.Open();
                adp.Fill(ds, "terreid");
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

        public bool DeleteData(Territories Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Territories WHERE TerritoryID=@catID";

            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@catID", Id.TerritoryID);

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
