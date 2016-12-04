using citiAppSystem.Modules.Agg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using citiAppSystem.Modules.Models;

namespace citiAppSystem.Modules.Repository
{
    public class AccDelRepo:IAccDelRepo
    {
        public List<AccDel> DeletedAccountList()
        {
            using (var conn = DbConnection.Connection)
            {
                string query = @"SELECT * FROM AccDelTable";
                return conn.Query<AccDel>(query).ToList();
            }
        }

        public void DeleteAccount(string AccountNo)
        {
           using (var conn = DbConnection.Connection)
           {
               string query = @"DELETE FROM deliveryReceipt
                                WHERE AccountNo = @AccountNo;

                                DELETE FROM collection 
                                WHERE Collection_ID = @AccountNo;

                                DELETE FROM collection_details 
                                WHERE Collection_ID = @AccountNo;

                                DELETE FROM DR_details 
                                WHERE AccountNo = @AccountNo;";
               conn.Query(query, new { AccountNo = AccountNo });
           }
        }



        public void Insert(AccDel obj)
        {
           using(var conn = DbConnection.Connection)
           {
               string query = @"INSERT INTO AccDelTable(DelDateTime,DelBy,UserId,AccountNo)VALUES(@DelDateTime,@DelBy,@UserId,@AccountNo)";
               conn.Query(query, obj);
           }
        }
    }
}
