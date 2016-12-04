using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IproductRepository
    {
        List<ProductsDatasets.productsRow> productList();

        ProductsDatasets.productsRow productByStockNo(string stockNo);
        List<ProductsDatasets.stockListReportRow> stockList();
        void UpdateStatus(string newStatus, string stockNo);
    }
}
