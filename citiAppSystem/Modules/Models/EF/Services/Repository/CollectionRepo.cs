using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public class CollectionRepo
    {
        citiAppDatabaseEntities context;
        public CollectionRepo()
        {
            context = new citiAppDatabaseEntities();
        }

        private IQueryable<collection> getCollections()
        {
            return context.collections.AsQueryable();
        }

        public List<collection> GetCollectionList()
        {
            return getCollections().Take(1000).ToList();
        }

        public collection CollectionByAccountNo(string accountNo)
        {
            return getCollections().Where(x => x.Collection_ID == accountNo).FirstOrDefault();
        }

    }
}
