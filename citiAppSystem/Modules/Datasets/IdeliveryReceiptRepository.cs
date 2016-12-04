using citiAppSystem.Modules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IdeliveryReceiptRepository
    {
        List<DeliveryReceiptDatasets.deliveryReceiptRow> DRList();

        List<DeliveryReceipt> AccountList();

        List<DeliveryReceipt> AccountListByName(string name);
        List<DeliveryReceipt> AccountListByAccountNo(string accountNo);

        List<DeliveryReceiptDatasets.deliveryReceiptRow> DrByAccountNo(string accountNo);

        DeliveryReceiptDatasets.deliveryReceiptDataTable DrTableByAcount(string accountNo);

        List<DeliveryReceiptDatasets.DR_detailsRow> DRDetailsByAccountNo(string accountNo);

        DeliveryReceiptDatasets.DR_detailsDataTable DrDetailsTableByAccountNo(string accountNo);

        DeliveryReceiptDatasets.DR_detailsDataTable GetDrDetails();

        void InsertDr(citiAppDatabaseDataSet.deliveryReceiptRow o);

        void InsertDRDetails(DeliveryReceiptDatasets.DR_detailsRow drDetailsRow);
        
        void UpdateStockNo(string newStockNo, string newModel,string newSerial,string newBrand,string oldstockNo);

        void UpdatePrimaryInstallment(string downPayment, string pn, string balance, string lcp, string orAMt, string orNumber, string drDetailsId);

        void UpdateDRforDR(string accType, string deliveryDate, string SI_DR_no, string salesman, string ciBy, string drNo, string drType, string accountNo);

        void UpdateAccountNo(string newAccountNo, string oldAccountNo);

        void UpdateDescriptionByStockNo(string description, string stockNo);

        void UpdateCustomer(string customerId,string accNo);
        void DeleteDrDetailsByPrimaryKey(string Dr_Details_ID);
    }

}
