using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public class CollectionDetailsTableRepo
    {
        citiAppDatabaseEntities dbContext;
        public CollectionDetailsTableRepo()
        {
            dbContext = new citiAppDatabaseEntities();
        }

        private  IQueryable<collection_details> getCollectonDetails()
        {
            return dbContext.collection_details.AsQueryable();
        }

        public List<collection_details> List()
        {
            return getCollectonDetails().ToList();
        }

        public List<collection_details> ListByAccountNo(string AccountNo)
        {
            return getCollectonDetails().Where(x => x.Collection_ID == AccountNo).ToList();
        }

        public void Add(collection_details a)
        {
            dbContext.collection_details.Add(a);
            dbContext.Entry(a).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }
        public void Update(collection_details a)
        {
            dbContext.collection_details.Add(a);
            dbContext.Entry(a).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
