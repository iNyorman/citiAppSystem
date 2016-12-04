using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IstockTransferRepository
    {
        stockTransferDatasets.st_requisitionTableDataTable GetSt_requisitionTable();
        stockTransferDatasets.transferTableDataTable GetTransferTable();
        stockTransferDatasets.st_requisitionTableDataTable GetSt_requisitionByST_ID(string st_Id);
        stockTransferDatasets.transferTableDataTable GetTransferTableByST_ID(string st_Id);
        void Insert_StRequisition(stockTransferDatasets.st_requisitionTableRow obj);
        void Insert_Transfer(stockTransferDatasets.transferTableRow obj);
        void TransferStock(string stockNo, string from_loc, string to_loc, string branchNo, string st_Id);
    }
}
