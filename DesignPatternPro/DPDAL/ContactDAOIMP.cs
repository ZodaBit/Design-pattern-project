using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAL;
using System.Data.SqlClient;
using System.Data;
using DPDTO;

namespace DPDAL
{
    public class ContactDAOIMP:ICrudDAO<Contact>
    {
         SqlConnection con = DBconnection.con;

         public bool CreateData(Contact obj)
         {

             int inserted = 0;
             string sqlInserte = "INSERT INTO Contacts (ContactType,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Extension,Fax,HomePage,PhotoPath,Photo) VALUES (@contactType,@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@extension,@fax,@homepage,@photoPath,@photo)";
             SqlCommand cmd = new SqlCommand(sqlInserte, con);

             cmd.Parameters.AddWithValue("@contactType", obj.ContactType);
             cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
             cmd.Parameters.AddWithValue("@contactName", obj.ContactName);
             cmd.Parameters.AddWithValue("@contactTitle", obj.ContactTitle);
             cmd.Parameters.AddWithValue("@address", obj.Address);
             cmd.Parameters.AddWithValue("@city", obj.City);
             cmd.Parameters.AddWithValue("@region", obj.Region);
             cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
             cmd.Parameters.AddWithValue("@country", obj.Country);
             cmd.Parameters.AddWithValue("@phone", obj.Phone);
             cmd.Parameters.AddWithValue("@extension", obj.Extension);
             cmd.Parameters.AddWithValue("@fax", obj.Fax);
             cmd.Parameters.AddWithValue("@homePage", obj.HomePage);
             cmd.Parameters.AddWithValue("@photoPath", obj.PhotoPath);
             SqlParameter pr = cmd.Parameters.AddWithValue("@photo", SqlDbType.Binary);
             pr.Value = obj.Photo;
             pr.Size = obj.Photo.Length;


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

         public bool UpdateData(Contact obj)
         {
             int Updated = 0;
             string sqlUpdateUser = "UPDATE Contacts  SET  ContactType=@ContactType,CompanyName=@companyName,ContactName=@contactName,ContactTitle=@contactTitle,Address=@address,City=@city,Region=@region,PostalCode=@postalCode,Country=@country,Phone=@phone,Extension=@extension,Fax=@fax,HomePage=@homePage,PhotoPath=@photoPath,Photo=@photo WHERE ContactID=@contactId";
             SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

             cmd.Parameters.AddWithValue("@contactId", obj.ContactID);
             cmd.Parameters.AddWithValue("@ContactType", obj.ContactType);
             cmd.Parameters.AddWithValue("@companyName", obj.CompanyName);
             cmd.Parameters.AddWithValue("@contactName", obj.ContactName);
             cmd.Parameters.AddWithValue("@contactTitle", obj.ContactTitle);
             cmd.Parameters.AddWithValue("@address", obj.Address);
             cmd.Parameters.AddWithValue("@city", obj.City);
             cmd.Parameters.AddWithValue("@region", obj.Region);
             cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
             cmd.Parameters.AddWithValue("@country", obj.Country);
             cmd.Parameters.AddWithValue("@phone", obj.Phone);
             cmd.Parameters.AddWithValue("@extension", obj.Extension);
             cmd.Parameters.AddWithValue("@fax", obj.Fax);
             cmd.Parameters.AddWithValue("@homePage", obj.HomePage);
             cmd.Parameters.AddWithValue("@photoPath", obj.PhotoPath);
             SqlParameter pr = cmd.Parameters.AddWithValue("@photo", SqlDbType.Binary);
             pr.Value = obj.Photo;
             pr.Size = obj.Photo.Length;

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
             string sqlallemp = "SELECT * FROM Contacts";
             SqlCommand cmd = new SqlCommand(sqlallemp, con);
             SqlDataAdapter adp = new SqlDataAdapter(cmd);



             DataSet ds = new DataSet();


             try
             {
                 con.Open();
                 adp.Fill(ds, "Cont");
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

         public DataSet GetDataByID(Contact Id)
         {
             string sqlSearch = "SELECT * FROM Contacts WHERE ContactID =@contactID";
             SqlCommand cmd = new SqlCommand(sqlSearch, con);
             SqlDataAdapter adp = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             cmd.Parameters.AddWithValue("@contactID", Id.ContactID);
             try
             {
                 con.Open();
                 adp.Fill(ds, "conid");
             }
             catch
             {
                 throw;
             }
             finally
             {
                 con.Close();
             }

             return ds; // 
         }

         public DataSet GetDataByName(Contact Name)
         {

             string sqlSearch = "SELECT * FROM Contacts WHERE ContactName =@contactname";
             SqlCommand cmd = new SqlCommand(sqlSearch, con);
             SqlDataAdapter adp = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             cmd.Parameters.AddWithValue("@contactID", Name.ContactName);
             try
             {
                 con.Open();
                 adp.Fill(ds, "conname");
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

         public bool DeleteData(Contact Id)
         {
             int deleted = 0;

             string updateemp = "DELETE FROM Contacts WHERE ContactID=@id";
             SqlCommand cmd = new SqlCommand(updateemp, con);

             cmd.Parameters.AddWithValue("@id", Id.ContactID);

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
