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
    public class EmployeeDAOIMP:ICrudDAO<Employee>
    {
        SqlConnection con = DBconnection.con;
       

        public bool CreateData(Employee obj)
        {
            int inserted = 0;
            string sqlInserte = "INSERT INTO Employees (LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath) VALUES (@lastName, @firstName,@title,@titleofCourtesy,@birthDate,@hirreDate,@address,@city,@region,@postalCode,@country,@homePhone,@extension,@photo,@notes,@reporstTo ,@photoPath)";
            SqlCommand cmd = new SqlCommand(sqlInserte, con);

            cmd.Parameters.AddWithValue("@lastName", obj.LastName);
            cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@title", obj.Title);
            cmd.Parameters.AddWithValue("@titleofCourtesy", obj.TitleofCourtesy);
            cmd.Parameters.AddWithValue("@birthDate", obj.BirthDate);
            cmd.Parameters.AddWithValue("@hirreDate", obj.HirreDate);
            cmd.Parameters.AddWithValue("@address", obj.Address);
            cmd.Parameters.AddWithValue("@city", obj.City);
            cmd.Parameters.AddWithValue("@region", obj.Region);
            cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
            cmd.Parameters.AddWithValue("@country", obj.Country);
            cmd.Parameters.AddWithValue("@homePhone", obj.HomePhone);
            cmd.Parameters.AddWithValue("@extension", obj.Extension);
            SqlParameter imgparameter = cmd.Parameters.AddWithValue("@photo", SqlDbType.Binary);
            imgparameter.Value = obj.Photo;
            imgparameter.Size = obj.Photo.Length;
            cmd.Parameters.AddWithValue("@notes", obj.Notes);
            cmd.Parameters.AddWithValue("@reporstTo", obj.ReporstTo);
            cmd.Parameters.AddWithValue("@photoPath", obj.PhotoPath);

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

        public bool UpdateData(Employee obj)
        {
            int Updated = 0;
            string sqlUpdateUser = "UPDATE Employees SET  LastName=@lastName,FirstName=@firstName,Title=@title,TitleOfCourtesy=@titleofCourtesy,BirthDate=@birthDate,HireDate=@hirreDate,Address=@address,City=@city,Region=@region,PostalCode=@postalCode,Country=@country,HomePhone=@homePhone,Extension=@extension,Photo=@photo,Notes=@notes,ReportsTo=@reporstTo,PhotoPath=@photoPath WHERE EmployeeID=@employeeId";
            SqlCommand cmd = new SqlCommand(sqlUpdateUser, con);

            cmd.Parameters.AddWithValue("@lastName", obj.LastName);
            cmd.Parameters.AddWithValue("@firstName", obj.FirstName);
            cmd.Parameters.AddWithValue("@title", obj.Title);
            cmd.Parameters.AddWithValue("@titleofCourtesy", obj.TitleofCourtesy);
            cmd.Parameters.AddWithValue("@birthDate", obj.BirthDate);
            cmd.Parameters.AddWithValue("@hirreDate", obj.HirreDate);
            cmd.Parameters.AddWithValue("@address", obj.Address);
            cmd.Parameters.AddWithValue("@city", obj.City);
            cmd.Parameters.AddWithValue("@region", obj.Region);
            cmd.Parameters.AddWithValue("@postalCode", obj.PostalCode);
            cmd.Parameters.AddWithValue("@country", obj.Country);
            cmd.Parameters.AddWithValue("@homePhone", obj.HomePhone);
            cmd.Parameters.AddWithValue("@extension", obj.Extension);
            SqlParameter imgparameter = cmd.Parameters.AddWithValue("@photo", SqlDbType.Binary);
            imgparameter.Value = obj.Photo;
            imgparameter.Size = obj.Photo.Length;
            cmd.Parameters.AddWithValue("@notes", obj.Notes);
            cmd.Parameters.AddWithValue("@reporstTo", obj.ReporstTo);
            cmd.Parameters.AddWithValue("@photoPath", obj.PhotoPath);
            cmd.Parameters.AddWithValue("@employeeId", obj.EmployeeID);

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
            string sqlallemp = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(sqlallemp, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);



            DataSet ds = new DataSet();


            try
            {
                con.Open();
                adp.Fill(ds, "Emp");
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

        public DataSet GetDataByID(Employee Id)
        {
            string sqlSearch = "SELECT * FROM Employees WHERE EmployeeID =@empid ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@empid", Id.EmployeeID);
            try
            {
                con.Open();
                adp.Fill(ds, "EmpId");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ds; 
        }

        public DataSet GetDataByName(Employee Name)
        {
            string sqlSearch = "SELECT * FROM Employees WHERE FirstName =@empname ";
            SqlCommand cmd = new SqlCommand(sqlSearch, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Parameters.AddWithValue("@empname", Name.FirstName);
            try
            {
                con.Open();
                adp.Fill(ds, "Empname");
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return ds; 
        }

        public bool DeleteData(Employee Id)
        {
            int deleted = 0;

            string updateemp = "DELETE FROM Employees WHERE EmployeeID=@id";
            SqlCommand cmd = new SqlCommand(updateemp, con);

            cmd.Parameters.AddWithValue("@id", Id.EmployeeID);

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
