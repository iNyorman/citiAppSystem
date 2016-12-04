using citiAppSystem.Modules.Datasets.BranchesDatasetsTableAdapters;
using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class branchesRepository : IbranchesRepository
    {
        branchTableAdapter adapter = new branchTableAdapter();
        public List<BranchesDatasets.branchRow> BranchList()
        {
            var list = adapter.GetData().Cast<BranchesDatasets.branchRow>().ToList();
            return list;
        }
    }
}
