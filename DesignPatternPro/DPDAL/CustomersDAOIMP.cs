using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DPBBL;

namespace DPDAL
{
    public class CustomersDAOIMP:ICrudDAO<Customer>
    {
        SqlConnection con = DBconnection.con;
        

        public bool CreateData(Customer obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) "
           + "VALUES (@customerID,@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);
            cmd.Parameters.AddWithValue("@customerID", obj.CustomerID);
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

        public bool UpdateData(Customer obj)
        {
            int updated = 0;
            string sqlUpdateUser = "UPDATE Customers SET  CompanyName=@companyName,ContactName=@contactName,ContactTitle=@contactTitle,Address=@address,City=@city,Region=@region,PostalCode=@postalCode,Country=@country,Phone=@phone,Fax=@fax WHERE CustomerID=@customerID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@customerID", obj.CustomerID);
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


            try
            {
                con.Open();
                updated = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            if (updated > 0)     //inserte is SuccesFull
                return true;
            else                 //inserte Failled
                return false; 
        }

        public DataSet GetAllData()
        {
            string sqlallemp = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "cust");
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

        public DataSet GetDataByID(Customer Id)
        {
            string sqlSearch = "SELECT * FROM Customers WHERE CustomerID =@customerID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@customerID", Id.CustomerID);
            try
            {
                con.Open();
                adp.Fill(ds, "cusid");
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

        public DataSet GetDataByName(Customer Name)
        {
            string sqlSearch = "SELECT * FROM Customers WHERE ContactName=@contactName";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@customerID", Name.ContactName);
            try
            {
                con.Open();
                adp.Fill(ds, "cusname");
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

        public bool DeleteData(Customer Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Customers WHERE CustomerID=@id";
            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@id", Id.CustomerID);

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
