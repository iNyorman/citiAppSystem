using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models
{
    public class StockTransferModel
    {
        public StockTransferModel()
        { 
        
        }

        public StockTransferModel(ProductsDatasets.productsRow products)
        {
            if (products != null)
            {
                stockNo = products.stockNo;
                Brand = products.brand;
                Model = products.model;
                Serial = products.serialNo;
                Status = products.status;
                currentBranch = products.loc_To;

            }
        }
        public string stockNo { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Serial { get; set; }

        public string Status { get; set; }
        public string  currentBranch { get; set; }
    }
}
