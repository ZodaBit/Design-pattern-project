using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DPDAL;
using DPDTO;
using Factory;

namespace DPBBL
{
    class CustomerBBL:ICRUDState<Customer>
    {
        ICrudDAO<Customer> Obj = (ICrudDAO<Customer>)FactoryProducer.GetDAOIMPObject("Customer");
        public bool Create(Customer obj)
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

        public bool Update(Customer obj)
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

        public DataSet SearchID(Customer Id)
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

        public DataSet SearchName(Customer Name)
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

        public bool Delete(Customer Id)
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
