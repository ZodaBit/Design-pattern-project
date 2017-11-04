using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DPDTO;
using DPDAL;
using Factory;
namespace DPBBL
{
    class SupplierBBL:ICRUDState<Supplier>
    {
        ICrudDAO<Supplier> Obj = (ICrudDAO<Supplier>)FactoryProducer.GetDAOIMPObject("Supplier");
        public bool Create(Supplier obj)
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

        public bool Update(Supplier obj)
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

        public DataSet SearchID(Supplier Id)
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

        public DataSet SearchName(Supplier Name)
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

        public bool Delete(Supplier Id)
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
