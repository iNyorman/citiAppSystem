using citiAppSystem.Modules.Models.EF.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services
{
    public class CitiAppDbServices
    {
        public CitiAppDbServices()
        {

        }
        public static CitiAppDbServices Services()
        {
            var ret = new CitiAppDbServices();
            return ret;
        }

        
        public CTransactionTableRepo CashierTransactions()
        {
            return new CTransactionTableRepo();
        }

        public  DRTableRepo deliveryReceipt()
        {
            return new DRTableRepo();
        }

        public DrDetailsRepo DR_Details()
        {
            return new DrDetailsRepo();
        }

        public  CustomerTableRepo customer()
        {
            return new CustomerTableRepo();
        }

        public CollectionRepo Collection()
        {
            return new CollectionRepo();
        }
        public  CollectionDetailsTableRepo collectionDetails()
        {
            return new CollectionDetailsTableRepo();
        }
    }
}
