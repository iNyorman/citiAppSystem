using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IbranchesRepository
    {
        List<BranchesDatasets.branchRow> BranchList();
    }
}
