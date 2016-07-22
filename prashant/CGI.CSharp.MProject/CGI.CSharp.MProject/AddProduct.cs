using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGI.CSharp.MProject
{
    class AddProduct
    {
        public string PrName { get; set; }
        public string PrCategory { get; set; }
        public float PrPrice { get; set; }
        public string PrDescription { get; set; }
        public int Quantity { get; set; }
        public string ProductId { get; set; }

        public AddProduct(string PrName,string PrCategory,float PrPrice,string PrDescription,int quantity,string ProductId)
        {
            this.PrName = PrName;
            this.PrCategory = PrCategory;
            this.PrPrice = PrPrice;
            this.PrDescription = PrDescription;
            this.Quantity = quantity;
            this.ProductId = ProductId;
        }
      

        public AddProduct()
        {

        }
    }
}
