using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Services.Repository
{
    public class CustomerTableRepo
    {
        citiAppDatabaseEntities dbContext;
        public CustomerTableRepo()
        {
            dbContext = new citiAppDatabaseEntities();
        }

        public IQueryable<customerTable> getCustomer()
        {
            return dbContext.customerTables.AsQueryable();
        }
        public List<customerTable> CustomerList()
        {
            return dbContext.customerTables.ToList();
        }

        public customerTable CustomerByFullname(string fullname)
        {
            return getCustomer().Where(x => x.fullName.ToUpper().Contains(fullname.ToUpper())).FirstOrDefault();
        }

        public customerTable CustomerByIdNumber(string IdNumber)
        {
            return dbContext.customerTables.FirstOrDefault(x => x.ID_Number == IdNumber);
        }

        public void Add(customerTable a)
        {
            dbContext.customerTables.Add(a);
            dbContext.Entry(a).State = System.Data.Entity.EntityState.Added;
            dbContext.SaveChanges();
        }

        public void Update(customerTable a)
        {
            dbContext.customerTables.Add(a);
            dbContext.Entry(a).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(customerTable a )
        {
            dbContext.customerTables.Attach(a);
            dbContext.customerTables.Remove(a);
            dbContext.SaveChanges();
        }
        
    }
}
