using citiAppSystem.Modules.Datasets;
using citiAppSystem.Modules.Datasets.CustomerDatasetsTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Repository
{
    public class customerRepository : IcustomerRepository
    {
        customerTableTableAdapter adapter = new customerTableTableAdapter();

        public CustomerDatasets.customerTableDataTable CustomerByID_Number(string Id_Number)
        {
            return adapter.GetDataByID_Number(Id_Number);
        }

        public CustomerDatasets.customerTableDataTable CustomerList()
        {
            CustomerDatasets.customerTableDataTable dt = adapter.GetData();
            return dt;
        }

        public CustomerDatasets.customerTableDataTable GetByName(string name)
        {
            return adapter.GetDataByFullName(name);
        }


        public void Insert(CustomerDatasets.customerTableRow obj)
        {
            adapter.Insert(obj.ID_Number,
                obj.last_Name,
                obj.mid_Name,
                obj.f_Name,
                obj.employer,
                obj.contact, obj.co_Maker,
                obj.address,
                obj.co_MakerAddress,
                obj.civil_status,
                obj.employerAddress,
                obj.fullName);
        }


        public void UpdateForDeliveryReceipt(string name, string address, string employer, string emp_address, string co_Maker, string co_address,string ID_Number)
        {
            var customerName = name.Split(',');

            string firstname = "";
            string middlename = "";
            string lastname = "";
            string fName = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                else
                {
                    middlename = "";
                }
                fName = lastname + "," + firstname + "," + middlename;
            }
            else
            {
                fName = name;
            }
            adapter.UpdateForDeliveryReceipt(employer, co_Maker, address, co_address, emp_address, fName, lastname, middlename, firstname, ID_Number);
        }


        public CustomerDatasets.customerTableDataTable GetLikefullname(string fname)
        {
            return adapter.GetDataByLikeFullname(fname);
        }


        public void InsertForDr(string name, string address, string employer, string emp_address, string co_Maker, string co_address, string ID_Number)
        {
             var customerName = name.Split(',');

            string firstname = "";
            string middlename = "";
            string lastname = "";
            string fName = "";
            if (customerName.Length >= 2)
            {
                lastname = customerName[0];
                firstname = customerName[1];
                if (customerName.Length == 3)
                {
                    middlename = customerName[2];
                }
                else
                {
                    middlename = "";
                }
                fName = lastname + "," + firstname + "," + middlename;
            }
            else
            {
                fName = name;
            }
            adapter.Insert(ID_Number, lastname, middlename, fName, employer, "-", co_Maker, address, co_address, "-", emp_address, fName);
        }
    }
}
