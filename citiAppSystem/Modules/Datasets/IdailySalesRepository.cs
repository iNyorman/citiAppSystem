﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IdailySalesRepository
    {
        dailySalesDatasets.DailySalesDataTable GetDailySales(string startDate,string endDate,string branchNo);
    }
}
