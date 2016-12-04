using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IcustomerRepository
    {
        CustomerDatasets.customerTableDataTable CustomerList();

        CustomerDatasets.customerTableDataTable CustomerByID_Number(string Id_Number);
        CustomerDatasets.customerTableDataTable GetByName(string name);

        CustomerDatasets.customerTableDataTable GetLikefullname(string fname);
        void Insert(CustomerDatasets.customerTableRow obj);

        void InsertForDr(string name, string address, string employer, string emp_address, string co_Maker, string co_address, string ID_Number);
        void UpdateForDeliveryReceipt(string name, string address, string employer, string emp_address, string co_Maker, string co_address,string ID_Number);
    }
}
