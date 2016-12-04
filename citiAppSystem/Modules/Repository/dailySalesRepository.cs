using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.dailySalesDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class dailySalesRepository:IdailySalesRepository
    {
        DailySalesTableAdapter adapter = new DailySalesTableAdapter();
        public dailySalesDatasets.DailySalesDataTable GetDailySales(string startDate, string endDate, string branchNo)
        {
            return adapter.GetDataBydate(startDate, endDate, branchNo);
        }
    }
}
