using citiAppSystem.Modules.Datasets.ProductsDatasetsTableAdapters;
using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class productRepository : IproductRepository
    {
        productsTableAdapter adapter = new productsTableAdapter();
        stockListReportTableAdapter adapter2 = new stockListReportTableAdapter();
        public List<ProductsDatasets.productsRow> productList()
        {
            var list = adapter.GetData().Cast<ProductsDatasets.productsRow>().ToList();
            return list;
        }


        public List<ProductsDatasets.stockListReportRow> stockList()
        {
            var list = adapter2.GetData().Cast<ProductsDatasets.stockListReportRow>().ToList();
            return list;
        }

        public void UpdateStatus(string newStatus, string stockNo)
        {
            adapter.UpdateProductStatus(newStatus, stockNo);
        }


        public ProductsDatasets.productsRow productByStockNo(string stockNo)
        {
            var row = adapter.GetDataByStockNo(stockNo).Cast<ProductsDatasets.productsRow>().FirstOrDefault();
            return row;
        }
    }
}
