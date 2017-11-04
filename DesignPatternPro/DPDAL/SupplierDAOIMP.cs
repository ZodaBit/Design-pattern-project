using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DPDTO;

namespace DPDAL
{
   public class SupplierDAOIMP:ICrudDAO<Supplier>
    {
        SqlConnection con = DBconnection.con;
       

        public bool CreateData(Supplier obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Suppliers (CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax,HomePage) VALUES (@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax,@homepage)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);


            cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
            cmd.Parameters.AddWithValue("@contactName", obj.ContactName);
            cmd.Parameters.AddWithValue("@contactTitle", obj.ContactTitle);
            cmd.Parameters.AddWithValue("@address", obj.Address);
            cmd.Parameters.AddWithValue("@city", obj.City);
            cmd.Parameters.AddWithValue("@region", obj.Region);
            cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
            cmd.Parameters.AddWithValue("@country", obj.Country);
            cmd.Parameters.AddWithValue("@phone", obj.Phone);
            cmd.Parameters.AddWithValue("@fax", obj.Fax);
            cmd.Parameters.AddWithValue("@homePage", obj.HomePage);


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

        public bool UpdateData(Supplier obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Suppliers  SET  CompanyName=@companyName,ContactName=@contactName,ContactTitle=@contactTitle,Address=@address,City=@city,Region=@region,PostalCode=@postalCode,Country=@country,Phone=@phone,Fax=@fax,HomePage=@homePage WHERE SupplierID=@contactId";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@contactId", obj.SupplierID);
            cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
            cmd.Parameters.AddWithValue("@contactName", obj.ContactName);
            cmd.Parameters.AddWithValue("@contactTitle", obj.ContactTitle);
            cmd.Parameters.AddWithValue("@address", obj.Address);
            cmd.Parameters.AddWithValue("@city", obj.City);
            cmd.Parameters.AddWithValue("@region", obj.Region);
            cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
            cmd.Parameters.AddWithValue("@country", obj.Country);
            cmd.Parameters.AddWithValue("@phone", obj.Phone);

            cmd.Parameters.AddWithValue("@fax", obj.Fax);
            cmd.Parameters.AddWithValue("@homePage", obj.HomePage);

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
            string sqlallemp = "SELECT * FROM Suppliers";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "sup");
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

        public DataSet GetDataByID(Supplier Id)
        {
            string sqlSearch = "SELECT * FROM Suppliers WHERE SupplierID =@contactID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@contactID", Id.SupplierID);
            try
            {
                con.Open();
                adp.Fill(ds, "subid");
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

        public DataSet GetDataByName(Supplier Name)
        {
            string sqlSearch = "SELECT * FROM Suppliers WHERE ContactName LIKE" + Name.ContactName;
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adp.Fill(ds, "subname");
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

        public bool DeleteData(Supplier Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Suppliers WHERE SupplierID =@id";
            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@id", Id.SupplierID);

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
