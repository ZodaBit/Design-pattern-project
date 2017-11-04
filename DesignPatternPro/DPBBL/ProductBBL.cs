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
    public class ProductBBL:ICRUDState<Product>
    {
        ICrudDAO<Product> ObjPro = (ICrudDAO<Product>)FactoryProducer.GetDAOIMPObject("Product");
         

        public bool Create(Product obj)
        {
            try
            {
                return ObjPro.CreateData(obj);
            }
            catch
            {
                throw;
            }
        }

        public bool Update(Product obj)
        {
            try
            {
                return ObjPro.UpdateData(obj);
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
                return ObjPro.GetAllData();
            }
            catch
            {
                throw;
            }
        }

        public DataSet SearchID(Product Id)
        {
            try
            {
                return ObjPro.GetDataByID(Id);
            }
            catch
            {
                throw;
            }
        }
        public DataSet SearchName(Product Name)
        {
            try
            {
                return ObjPro.GetDataByName(Name);
            }
            catch
            {
                throw;
            }
        }
        
        public bool Delete(Product Id)
        {
            try
            {
                return ObjPro.DeleteData(Id);
            }
            catch
            {
                throw;
            }
        }
    }
}
