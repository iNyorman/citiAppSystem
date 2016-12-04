using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public class DrDetailsRepo
    {
        citiAppDatabaseEntities context;
        public DrDetailsRepo()
        {
            context = new citiAppDatabaseEntities();
        }

        private IQueryable<DR_details> getDrDetails()
        {
            return context.DR_details.AsQueryable();
        }

        public List<DR_details> GetDrDetailsList()
        {
          return getDrDetails().Take(1000).ToList();
        }

        public List<DR_details> GetDrDetailsByAccountNo(string accountNo)
        {
            return getDrDetails().Where(x => x.AccountNo.Equals(accountNo)).ToList();
        }
    }
}
