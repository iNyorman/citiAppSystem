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
        public static CTransactionTableRepo CashierTransactions()
        {
            return new CTransactionTableRepo();
        }

        public static DRTableRepo deliveryReceipt()
        {
            return new DRTableRepo();
        }

        public static CustomerTableRepo customer()
        {
            return new CustomerTableRepo();
        }

        public static CollectionDetailsTableRepo collectionDetails()
        {
            return new CollectionDetailsTableRepo();
        }
    }
}
