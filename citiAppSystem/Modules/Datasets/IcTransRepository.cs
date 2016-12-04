using citiAppSystem.Modules.Datasets.cTransDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IcTransRepository
    {
        c_TransTableTableAdapter DataAdapter();
        cTransDatasets.c_TransTableDataTable cTransList();
        cTransDatasets.c_TransTableDataTable GetDataByOR(string or,string branchNo);
    }
}
