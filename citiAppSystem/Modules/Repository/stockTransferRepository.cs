using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.ProductsDatasetsTableAdapters;
using citiAppSystem.Modules.Datasets.stockTransferDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class stockTransferRepository:IstockTransferRepository
    {
        st_requisitionTableTableAdapter adapter = new st_requisitionTableTableAdapter();
        transferTableTableAdapter adapter2 = new transferTableTableAdapter();
        productsTableAdapter adapter3 = new productsTableAdapter();
        public stockTransferDatasets.st_requisitionTableDataTable GetSt_requisitionTable()
        {
            return adapter.GetData();
        }

        public stockTransferDatasets.transferTableDataTable GetTransferTable()
        {
            return adapter2.GetData();
        }

        public stockTransferDatasets.st_requisitionTableDataTable GetSt_requisitionByST_ID(string st_Id)
        {
            return adapter.GetDataBy_St_Id(st_Id);
        }

        public stockTransferDatasets.transferTableDataTable GetTransferTableByST_ID(string st_Id)
        {
            return adapter2.GetDataBySt_Id(st_Id);
        }

        public void Insert_StRequisition(stockTransferDatasets.st_requisitionTableRow obj)
        {
            adapter.Insert(obj.st_ID, obj.date_Transaction, obj.transfer_location, obj.gatePassNo, obj.receivedBy, obj.releasedBy, obj.from_location);
        }
        public void Insert_Transfer(stockTransferDatasets.transferTableRow obj)
        {
            adapter2.Insert(obj.transfer_ID, obj.stockNo, obj.trans_Date, obj.transferLocation, obj.qnty, obj.st_ID);
        }


        public void TransferStock(string stockNo, string from_loc, string to_loc, string branchNo, string st_Id)
        {
            adapter3.stockTransferProduct(from_loc, to_loc, st_Id, stockNo);
        }
    }
}
