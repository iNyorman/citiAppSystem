using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
     public interface IfreeProductsRepository
    {
         freeProductsDatasets.freeProductDataTable FreeProducts();
         freeProductsDatasets.freeProductDataTable FreeProductsByMain(string stockNo);
         freeProductsDatasets.freeProductDataTable FreeProductsByFree(string stockNo);
         void Insert(freeProductsDatasets.freeProductRow obj);
    }
}
