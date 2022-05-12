using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GroceryExpenseTracker
{
    namespace Model
    {
        public class Product
        {
            public string Name;
            public UInt32 QTY;
            public float  UnitPrice;
        }

        public class PurchaseList
        {
            public string        MarketName;
            public DateTime      Date        = DateTime.Now;
            public List<Product> ProductList = new List<Product>();
        }

        public class PurchaseHistory
        {
            public List<PurchaseList> History = new List<PurchaseList>();

            public void Save(string file)
            {
                File.WriteAllText(file, JsonConvert.SerializeObject(this, Formatting.None));
            }
        }
    }
}
