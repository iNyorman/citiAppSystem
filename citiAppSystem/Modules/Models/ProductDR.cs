using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models
{
    public class ProductDR
    {
        public ProductDR()
        { 
        
        }

        public ProductDR(DeliveryReceiptDatasets.DR_detailsRow obj)
        {
            stockNo = obj.stockNo;
            Brand = obj.brand;
            Model = obj.model;
            Serial = obj.serialNo;
            Remarks = obj.pStatus;
            Price = obj.orAmt;
            pn = obj.PN;
        }

        public string stockNo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Serial { get; set; }
        public string Remarks { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Indentifier { get; set; }
        public string pn { get; set; }
    }
}
