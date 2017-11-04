using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDTO;
using DPDAL;
using Factory;
using System.Data;
namespace DPBBL
{
    class EmployeeBBL:ICRUDState<Employee>
    {
        ICrudDAO<Employee> Obj = (ICrudDAO<Employee>)FactoryProducer.GetDAOIMPObject("Employee");
        public bool Create(Employee obj)
        {
            try
            {
                return Obj.CreateData(obj);
            }
            catch
            {
                throw;
            }
        }

        public bool Update(Employee obj)
        {

            try
            {
                return Obj.UpdateData(obj);
            }
            catch
            {
                throw;
            }
        }

        public DataSet GetAll()
        {

            try
            {
                return Obj.GetAllData();
            }
            catch
            {
                throw;
            }
        }

        public DataSet SearchID(Employee Id)
        {

            try
            {
                return Obj.GetDataByID(Id);
            }
            catch
            {
                throw;
            }
        }

        public DataSet SearchName(Employee Name)
        {

            try
            {
                return Obj.GetDataByName(Name);
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Employee Id)
        {

            try
            {
                return Obj.DeleteData(Id);
            }
            catch
            {
                throw;
            }
        }
    }
}
