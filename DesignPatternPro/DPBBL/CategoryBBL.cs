using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAL;
using DPDTO;
using Factory;
using System.Data;

namespace DPBBL
{
    class CategoryBBL:ICRUDState<Category>
    {
        ICrudDAO<Category> Obj = (ICrudDAO<Category>)FactoryProducer.GetDAOIMPObject("Category");
        public bool Create(Category obj)
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

        public bool Update(Category obj)
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

        public DataSet SearchID(Category Id)
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

        public DataSet SearchName(Category Name)
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

        public bool Delete(Category Id)
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
