using citiAppSystem.Modules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Agg
{
    public interface IAccDelRepo
    {
        List<AccDel> DeletedAccountList();
        void DeleteAccount(string AccountNo);
        void Insert(AccDel obj);

    }
}
