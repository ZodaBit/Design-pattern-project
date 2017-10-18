using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPDAL;

namespace Factory
{
    public static class FactoryProducer
    {
        private static Dictionary<string, Object> AllObj = new Dictionary<string, Object>();

         static FactoryProducer()
        {
            AllObj.Add("Customer", new CustomersDAOIMP());
            AllObj.Add("Category", new CategoryDAOIMP());
            AllObj.Add("Contact", new ContactDAOIMP());
            AllObj.Add("Employee",new EmployeeDAOIMP());
            AllObj.Add("Order", new OrderDAOIMP());
            AllObj.Add("Product", new ProductDAOIMP());
            AllObj.Add("Region", new RegionDAOIMP());
            AllObj.Add("Shipper", new ShipperDAOIMP());
            AllObj.Add("Supplier", new SupplierDAOIMP());
            AllObj.Add("Territories", new TerritoriesDAOIMP());
            
        }
        public static Object GetDAOIMPObject(string myobject)
        {
            return AllObj[myobject];
        }
    }
}
