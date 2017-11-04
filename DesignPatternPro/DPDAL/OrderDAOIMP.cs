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
   public class OrderDAOIMP:ICrudDAO<Order>
    {
        SqlConnection con = DBconnection.con;

      

        public bool CreateData(Order obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Orders (CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry)" +
                " VALUES (@customerID,@employeeID,@orderDate,@requiredDate,@shippedDate,@shipVia,@freight,@shipName,@shipAddress,@shipCity,@shipRegion,@shipPostalCode,@shipCountry)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);


            cmd.Parameters.AddWithValue("@customerID", obj.CustomerID);
            cmd.Parameters.AddWithValue("@employeeID ", obj.EmployeeID);
            cmd.Parameters.AddWithValue("@orderDate", obj.OrderDate);
            cmd.Parameters.AddWithValue("@requiredDate", obj.RequiredDate);
            cmd.Parameters.AddWithValue("@shippedDate", obj.ShippedDate);
            cmd.Parameters.AddWithValue("@shipVia", obj.ShipVia);
            cmd.Parameters.AddWithValue("@freight", obj.Freight);
            cmd.Parameters.AddWithValue("@shipName", obj.ShipName);
            cmd.Parameters.AddWithValue("@shipAddress", obj.ShipAddress);
            cmd.Parameters.AddWithValue("@shipCity", obj.ShipCity);
            cmd.Parameters.AddWithValue("@shipRegion", obj.ShipRegion);
            cmd.Parameters.AddWithValue("@shipPostalCode", obj.ShipPostalCode);
            cmd.Parameters.AddWithValue("@shipCountry", obj.ShipCountry);


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

        public bool UpdateData(Order obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Orders  SET  CustomerID=@customerID,EmployeeID=@employeeID,OrderDate=@OrderDate," +
            "RequiredDate=@requiredDate,ShippedDate=@shippedDate,ShipVia=@shipVia,Freight=@freight,ShipName=@shipName,"
            + "ShipAddress=@shipAddress,ShipCity=@shipCity,ShipRegion=@shipRegion,ShipPostalCode=@shipPostalCode,ShipCountry=@shipCountry WHERE OrderID=@orderID";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);
            cmd.Parameters.AddWithValue("@orderID", obj.OrderID);
            cmd.Parameters.AddWithValue("@customerID", obj.CustomerID);
            cmd.Parameters.AddWithValue("@employeeID ", obj.EmployeeID);
            cmd.Parameters.AddWithValue("@orderDate", obj.OrderDate);
            cmd.Parameters.AddWithValue("@requiredDate", obj.RequiredDate);
            cmd.Parameters.AddWithValue("@shippedDate", obj.ShippedDate);
            cmd.Parameters.AddWithValue("@shipVia", obj.ShipVia);
            cmd.Parameters.AddWithValue("@freight", obj.Freight);
            cmd.Parameters.AddWithValue("@shipName", obj.ShipName);
            cmd.Parameters.AddWithValue("@shipAddress", obj.ShipAddress);
            cmd.Parameters.AddWithValue("@shipCity", obj.ShipCity);
            cmd.Parameters.AddWithValue("@shipRegion", obj.ShipRegion);
            cmd.Parameters.AddWithValue("@shipPostalCode", obj.ShipPostalCode);
            cmd.Parameters.AddWithValue("@shipCountry", obj.ShipCountry);

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
            string sqlallemp = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "ord");
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

        public DataSet GetDataByID(Order Id)
        {
            string sqlSearch = "SELECT * FROM Orders WHERE OrderID =@orderID";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@orderID", Id.OrderID);
            try
            {
                con.Open();
                adp.Fill(ds, "ordid");
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

        public DataSet GetDataByName(Order Name)
        {
            string sqlSearch = "SELECT * FROM Orders WHERE ShipName=@name";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@name", Name.ShipName);
            try
            {
                con.Open();
                adp.Fill(ds, "ordname");
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

        public bool DeleteData(Order Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Orders WHERE OrderID=@id";
            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@id", Id.OrderID);

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
