using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.cTransDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class cTransRepository : IcTransRepository
    {
        c_TransTableTableAdapter adapter = new c_TransTableTableAdapter();

        public  c_TransTableTableAdapter DataAdapter()
        {
            return new  c_TransTableTableAdapter();
        }
        public cTransDatasets.c_TransTableDataTable cTransList()
        {
            return adapter.GetData();
        }

        public cTransDatasets.c_TransTableDataTable GetDataByOR(string or,string branchNo)
        {
            return adapter.GetDataByORandBranchNo(or, branchNo);
        }
    }
}
