using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public  class DRTableRepo
    {
        citiAppDatabaseEntities dbContext;
        public DRTableRepo()
        {
            dbContext = new citiAppDatabaseEntities();
        }

        public List<deliveryReceipt> DrList()
        {
            return dbContext.deliveryReceipts.ToList();
        }

        public deliveryReceipt DrByAcount(string accountNo)
        {
            return dbContext.deliveryReceipts.FirstOrDefault(x => x.AccountNo == accountNo);
        }

    }
}
