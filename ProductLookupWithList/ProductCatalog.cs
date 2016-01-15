using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithList {
    class ProductCatalog {

        public Dictionary <string, Product> Products { get; set; }

        //Creating a Product constructor
        public ProductCatalog() {
            Products = new Dictionary<string, Product>();
            Products["UY1122NB"] = new Product() {
                Id = "UY1122NB",
                Name = "Coloring Book",
                Price = 10.99m
            };
            Products["UY1135NB"] = new Product() {
                Id = "UY1135NB",
                Name = "String Cheese",
                Price = 3.05m
            };
            Products["UY2345NB"] = new Product() {
                Id = "UY2345NB",
                Name = "Dark Chocolate Cookies",
                Price = 4.99m
            };
            
        }
        public Product Lookup(string id) {
            if (Products.ContainsKey(id)) {
                return Products[id];
            }
            //foreach (var p in Products) {
            //    if (p.Id == id) {
            //        return p;
            //    }
            //}
            ////return null;
            //return default(Product);
            return default(Product);
        }
    }

}

