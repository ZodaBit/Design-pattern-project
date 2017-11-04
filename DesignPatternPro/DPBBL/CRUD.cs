using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDTO;
using System.Data;
namespace DPBBL
{
   public class CRUD<T>
    {
       Factory fact = new Factory();   
        private ICRUDState<T> state;
        public CRUD(string _name)
        {
            state = (ICRUDState<T>)fact.Getstate(_name);
        }
        public bool Create(T obj)
        {
            return state.Create(obj);
        }
        public bool Update(T obj)
       {
           return state.Update(obj);
       }
        public DataSet GetAll()
        {
            return state.GetAll();
        }
        public DataSet SearchID(T Id)
        {
            return state.SearchID(Id);
        }
        public DataSet SearchName(T Name)
        {
            return state.SearchName(Name);
        }
        public bool Delete(T Id)
        {
            return state.Delete(Id);
        }

        
    }
}
