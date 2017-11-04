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
    class RegionBBL:ICRUDState<MyRegion>
    {
        ICrudDAO<MyRegion> Obj = (ICrudDAO<MyRegion>)FactoryProducer.GetDAOIMPObject("Region");
        public bool Create(MyRegion obj)
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

        public bool Update(MyRegion obj)
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

        public DataSet SearchID(MyRegion Id)
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

        public DataSet SearchName(MyRegion Name)
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

        public bool Delete(MyRegion Id)
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
