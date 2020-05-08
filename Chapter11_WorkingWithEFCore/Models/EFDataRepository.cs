using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Newtonsoft.Json;

namespace Chapter11_WorkingWithEFCore.Models {

    public class EFDataRepository : IDataRepository {
        private EFDatabaseContext context;

        public EFDataRepository(EFDatabaseContext ctx) {
            context = ctx;
        }

        public Product GetProduct(long id) {
			//Console.WriteLine("GetProduct: " + id);
			//Debug.WriteLine("GetProduct: " + id);
			//return new Product();

	        return context.Products.Find(id);

        }

        public IEnumerable<Product> GetAllProducts() {
            Console.WriteLine("GetAllProducts");
            return context.Products;
        }

        public void CreateProduct(Product newProduct)
        {
	        //Console.Clear();
			Console.WriteLine("CreateProduct");
			Debug.WriteLine("CreateProduct");
			context.Products.Add(newProduct);
	        context.SaveChanges();
	        //Console.WriteLine("CreateProduct: "  
	        //    + JsonConvert.SerializeObject(newProduct));
        }

        public void UpdateProduct(Product changedProduct) {

	        Console.WriteLine("UpdateProduct");

			//var _changedProduct = context.Products.Find(changedProduct.Id);
			context.Update(changedProduct);
	        context.SaveChanges();

			//Console.WriteLine("UpdateProduct : "
			//    + JsonConvert.SerializeObject(changedProduct));
		}

        public void DeleteProduct(long id) {

	        var _deleteProduct = context.Products.Find(id);

			context.Remove(_deleteProduct);
	        context.SaveChanges();

			//Console.WriteLine("DeleteProduct: " + id);
        }
    }
}
