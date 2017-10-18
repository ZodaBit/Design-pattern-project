using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPBBL;
using System.Data;

namespace DPDAL
{
    public interface ICrudDAO<T>
    {
        bool CreateData(T obj);
        bool UpdateData(T obj);
        DataSet GetAllData();
        DataSet GetDataByID(T Id);
        DataSet GetDataByName(T Name);
        bool DeleteData(T Id);
        
    }
}
