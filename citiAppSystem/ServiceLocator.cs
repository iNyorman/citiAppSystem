using citiAppSystem.Modules.Agg;
using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem
{
    public class ServiceLocator
    {

        private static ServiceLocator _locator;

        public static ServiceLocator Instance()
        {
            _locator = new ServiceLocator();
            return _locator;
        }

        public IproductRepository ProductServices()
        {
            IproductRepository repo = new productRepository();
            return repo;
        }

        public IbranchesRepository BranchServices()
        {
            IbranchesRepository repo = new branchesRepository();
            return repo;
        }

        public IdeliveryReceiptRepository DRServices()
        {
            IdeliveryReceiptRepository repo = new deliveryReceiptRepository();
            return repo;
        }
        public IcollectionRepository CollectionServices()
        {
            IcollectionRepository repo = new collectionRepository();
            return repo;
        }


        public IchangeLogRepository ChangesLogs()
        {
            IchangeLogRepository repo = new changeLogRepository();
            return repo;
        }

        public IcustomerRepository CustomerServices()
        {
            IcustomerRepository repo = new customerRepository();
            return repo;
        }

        public IcTransRepository CTransServices()
        {
            IcTransRepository repo = new cTransRepository();
            return repo;
        }

        public IfreeProductsRepository FreeProductServices()
        {
            IfreeProductsRepository repo = new freeProductsRepository();
            return repo;
        }
        public IdailySalesRepository DailySalesServices()
        {
            IdailySalesRepository repo = new dailySalesRepository();
            return repo;
        }
        public IstockTransferRepository StockTransferServices()
        {
            IstockTransferRepository repo = new stockTransferRepository();
            return repo;
        }

        public IAccDelRepo AccDelTableService()
        {
            IAccDelRepo repo = new AccDelRepo();
            return repo;
        }
    }
}
