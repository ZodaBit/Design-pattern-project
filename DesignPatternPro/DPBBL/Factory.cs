using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBBL
{
    public  class Factory
    {
        private  Dictionary<string, Object> state = new Dictionary<string, Object>();

         public Factory()
        {
            state.Add("Customer", new CustomerBBL());
            state.Add("Category", new CategoryBBL());
            state.Add("Contact", new ContactBBL());
            state.Add("Employee",new EmployeeBBL());
            state.Add("Order", new OrderBBL());
            state.Add("Product", new ProductBBL());
            state.Add("Region", new RegionBBL());
            state.Add("Shipper", new ShipperBBL());
            state.Add("Supplier", new SupplierBBL());
            state.Add("Territories", new TerritoriesBBL());
            
        }
        public  Object Getstate(string obj)
        {
            return state[obj];
        }

        
    }
}
