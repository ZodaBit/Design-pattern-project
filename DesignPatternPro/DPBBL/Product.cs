using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPBBL
{
   public class Product
    {
       public int ProductID {get;set;}
       public string ProductName {get;set;}
       public int SupplierID {get;set;}
       public int CategoryID {get;set;}
       public string QuantityPerUnit {get;set;}
       public Decimal UnitPrice {get;set;}
       public Int16 UnitsInStock {get;set;}
       public Int16 UnitsOnOrder {get;set;}
       public Int16 RecorderLevel {get;set;}
       public string Discontinued { get; set; }
    }
}
