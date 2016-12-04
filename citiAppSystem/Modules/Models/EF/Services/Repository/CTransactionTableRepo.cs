using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public class CTransactionTableRepo
    {
        citiAppDatabaseEntities dbContext;
        public CTransactionTableRepo()
        {
            dbContext = new citiAppDatabaseEntities();
        }

        private IQueryable<c_TransTable> GetCTransTable()
        {
            return dbContext.c_TransTable.AsQueryable();
        }

        public List<c_TransTable> CTransList()
        {
            return GetCTransTable().ToList();
        }

        public c_TransTable CTransByORNum(string OR_NUM,string branchNo)
        {
            return GetCTransTable().FirstOrDefault(x => x.OR_NUM == OR_NUM && x.branchNo == branchNo);
        }

        public void Add(c_TransTable ctransTable)
        {
            dbContext.c_TransTable.Add(ctransTable);
            dbContext.Entry(ctransTable).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }

        

        public void Update(c_TransTable ctransTable)
        {
            dbContext.c_TransTable.Add(ctransTable);
            dbContext.Entry(ctransTable).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(c_TransTable ctransTable)
        {
            dbContext.c_TransTable.Attach(ctransTable);
            dbContext.c_TransTable.Remove(ctransTable);
            dbContext.SaveChanges();
        }
    }
}
