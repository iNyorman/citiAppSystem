using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.ChangesLogDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class changeLogRepository : IchangeLogRepository
    {
        ChangesLogTableAdapter adapter = new ChangesLogTableAdapter();

        public List<ChangesLogDatasets.ChangesLogRow> List()
        {
            return adapter.GetData().Cast<ChangesLogDatasets.ChangesLogRow>().ToList();
        }
    }
}
