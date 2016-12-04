using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.freeProductsDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class freeProductsRepository:IfreeProductsRepository
    {
        freeProductTableAdapter adapter = new freeProductTableAdapter();
        public freeProductsDatasets.freeProductDataTable FreeProducts()
        {
            return adapter.GetData();
        }

        public freeProductsDatasets.freeProductDataTable FreeProductsByMain(string stockNo)
        {
            throw new NotImplementedException();
        }

        public freeProductsDatasets.freeProductDataTable FreeProductsByFree(string stockNo)
        {
            throw new NotImplementedException();
        }

        public void Insert(freeProductsDatasets.freeProductRow obj)
        {
            adapter.Insert(obj.FstockNo, obj.stockNo, obj.attachedStockNo);
        }
    }
}
