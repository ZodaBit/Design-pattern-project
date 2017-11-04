using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DPBBL
{
    interface ICRUDState<T>
    {
        bool Create(T obj);
        bool Update(T obj);
        DataSet GetAll();
        DataSet SearchID(T Id); 
        DataSet SearchName(T Name);
        bool Delete(T Id);
    }
}
