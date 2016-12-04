using citiAppSystem.Modules.Datasets.DeliveryReceiptDatasetsTableAdapters;
using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using citiAppSystem.Modules.Datasets.ChangesLogDatasetsTableAdapters;
using Dapper;

namespace citiAppSystem.Modules.Repository
{
    public class deliveryReceiptRepository : IdeliveryReceiptRepository
    {
        deliveryReceiptTableAdapter adapter; 
        DR_detailsTableAdapter adapter2; 
        ChangesLogTableAdapter adapter3; 

        public deliveryReceiptRepository()
        {
            adapter = new deliveryReceiptTableAdapter();
            adapter2 = new DR_detailsTableAdapter();
            adapter3 = new ChangesLogTableAdapter();
        }
        public List<DeliveryReceiptDatasets.deliveryReceiptRow> DRList()
        {
            var list = adapter.GetData().Cast<DeliveryReceiptDatasets.deliveryReceiptRow>().ToList();
            return list;
        }

        public List<DeliveryReceiptDatasets.deliveryReceiptRow> DrByAccountNo(string accountNo)
        {
            return  adapter.GetDataByAccountNo(accountNo).Cast<DeliveryReceiptDatasets.deliveryReceiptRow>().ToList();
        }

        public DeliveryReceiptDatasets.DR_detailsDataTable DrDetailsTableByAccountNo(string accountNo)
        {
            return adapter2.GetDataByAccountNo(accountNo);
        }



        public void UpdateAccountNo(string newAccountNo, string oldAccountNo)
        {
            adapter.UpdateAccountNo(newAccountNo, oldAccountNo);
            adapter.UpdateC_TransAccountNo(newAccountNo, oldAccountNo);
            adapter.UpdateDR_DetailsAccountNo(newAccountNo, oldAccountNo);
            adapter.UpdateCollectionId_AccountNo(newAccountNo, oldAccountNo);
            adapter.UpdateColDetails_CollectionID_AccountNo(newAccountNo, oldAccountNo);
            string message = "AccountNo " + oldAccountNo + " updated to " + newAccountNo + ".";
            adapter3.Insert("AccountNo", message, System.DateTime.UtcNow);

        }

        public void UpdateStockNo(string newStockNo,string newModel,string newSerial,string newBrand, string oldstockNo)
        {
            adapter2.UpdateStockNo(newStockNo, newModel,newSerial,newBrand, oldstockNo);
            string message = "StockNo " + oldstockNo + " updated to " + newStockNo + ".";
            adapter3.Insert("StockNo", message, System.DateTime.UtcNow);
        }

        public List<DeliveryReceiptDatasets.DR_detailsRow> DRDetailsByAccountNo(string accountNo)
        {
           return adapter2.GetDataByAccountNo(accountNo).Cast<DeliveryReceiptDatasets.DR_detailsRow>().ToList();
        }


        public void UpdateDescriptionByStockNo(string description, string stockNo)
        {
            adapter2.UpdateDescriptionByStockNo(description, stockNo);
        }

        public void UpdateDRforDR(string accType, string deliveryDate, string SI_DR_no, string salesman, string ciBy, string drNo, string drType, string accountNo)
        {
            adapter.UpdateQueryDRForDR(accType, deliveryDate, SI_DR_no, salesman, ciBy, drNo, drType,accountNo, accountNo);
        }


        public DeliveryReceiptDatasets.deliveryReceiptDataTable DrTableByAcount(string accountNo)
        {
            return adapter.GetDataByAccountNo(accountNo);
        }


        public void InsertDr(citiAppDatabaseDataSet.deliveryReceiptRow o)
        {
            var a = adapter.InsertQuery(o.AccountNo,
                                        o.Account_Type,
                                        o.SI_DR_no,
                                        o.Salesman,
                                        o.CI_By,
                                        o.ID_Number,
                                        o.Collection_ID,
                                        o.Status,
                                        o.Delivery_Date.ToShortDateString(),
                                        o.branchNo,
                                        o.DR_no,
                                        o.DRtype);
        }

        public void InsertDRDetails(DeliveryReceiptDatasets.DR_detailsRow o)
        {
          adapter2.Insert(o.DR_Details_ID,
                            o.LCP,
                            o.stockNo,
                            o.AccountNo,
                            o.qnty,
                            o.remarks,
                            o.down_payment,
                            o.or_number,
                            o.paymentType,
                            o.description,
                            o.pStatus,
                            o.cash,
                            o.orAmt,
                            o.model,
                            o.serialNo,
                            o.brand,
                            o.PN,
                            o.BalanceAF,
                            o.termsDR);
        }


        public DeliveryReceiptDatasets.DR_detailsDataTable GetDrDetails()
        {
            return adapter2.GetData();
        }

        public void UpdateCustomer(string customerId, string accNo)
        {
            adapter.UpdateCustomer(customerId,accNo);
        }


        public void DeleteDrDetailsByPrimaryKey(string Dr_Details_ID)
        {
            adapter2.DeleteQuery(Dr_Details_ID);
        }


        public List<Models.DeliveryReceipt> AccountList()
        {
            using(var conn = DbConnection.Connection)
            {
                string query = @"SELECT deliveryReceipt.Id, deliveryReceipt.AccountNo, deliveryReceipt.Account_Type, deliveryReceipt.Delivery_Date, deliveryReceipt.SI_DR_no, 
                         deliveryReceipt.Salesman, deliveryReceipt.CI_By, deliveryReceipt.ID_Number, deliveryReceipt.Status, branch.branchName, customerTable.last_Name, 
                         customerTable.mid_Name, customerTable.f_Name, customerTable.employer, customerTable.contact, customerTable.co_Maker, customerTable.address, 
                         customerTable.co_MakerAddress, customerTable.civil_status, customerTable.employerAddress, customerTable.fullName, deliveryReceipt.branchNo, 
                         deliveryReceipt.DR_no, deliveryReceipt.DRtype, deliveryReceipt.Collection_ID
                         FROM  deliveryReceipt INNER JOIN
                         customerTable ON deliveryReceipt.ID_Number = customerTable.ID_Number INNER JOIN
                         branch ON deliveryReceipt.branchNo = branch.branchNo";
                var a = conn.Query<Models.DeliveryReceipt>(query).ToList();
                return a;
            }
        }


        public List<Models.DeliveryReceipt> AccountListByName(string name)
        {
            using (var conn = DbConnection.Connection)
            {
                string query = @"SELECT TOP 1000 deliveryReceipt.Id, deliveryReceipt.AccountNo, deliveryReceipt.Account_Type, deliveryReceipt.Delivery_Date, deliveryReceipt.SI_DR_no, 
                         deliveryReceipt.Salesman, deliveryReceipt.CI_By, deliveryReceipt.ID_Number, deliveryReceipt.Status, branch.branchName, customerTable.last_Name, 
                         customerTable.mid_Name, customerTable.f_Name, customerTable.employer, customerTable.contact, customerTable.co_Maker, customerTable.address, 
                         customerTable.co_MakerAddress, customerTable.civil_status, customerTable.employerAddress, customerTable.fullName, deliveryReceipt.branchNo, 
                         deliveryReceipt.DR_no, deliveryReceipt.DRtype, deliveryReceipt.Collection_ID
                         FROM  deliveryReceipt INNER JOIN
                         customerTable ON deliveryReceipt.ID_Number = customerTable.ID_Number INNER JOIN
                         branch ON deliveryReceipt.branchNo = branch.branchNo
                         WHERE customerTable.fullName LIKE '%' + @cname + '%'";
                var a = conn.Query<Models.DeliveryReceipt>(query, new { cname = name}).ToList();
                return a;
            }
        }

        public List<Models.DeliveryReceipt> AccountListByAccountNo(string accountNo)
        {
            using (var conn = DbConnection.Connection)
            {
                string query = @"SELECT TOP 1000 deliveryReceipt.Id, deliveryReceipt.AccountNo, deliveryReceipt.Account_Type, deliveryReceipt.Delivery_Date, deliveryReceipt.SI_DR_no, 
                         deliveryReceipt.Salesman, deliveryReceipt.CI_By, deliveryReceipt.ID_Number, deliveryReceipt.Status, branch.branchName, customerTable.last_Name, 
                         customerTable.mid_Name, customerTable.f_Name, customerTable.employer, customerTable.contact, customerTable.co_Maker, customerTable.address, 
                         customerTable.co_MakerAddress, customerTable.civil_status, customerTable.employerAddress, customerTable.fullName, deliveryReceipt.branchNo, 
                         deliveryReceipt.DR_no, deliveryReceipt.DRtype, deliveryReceipt.Collection_ID
                         FROM  deliveryReceipt INNER JOIN
                         customerTable ON deliveryReceipt.ID_Number = customerTable.ID_Number INNER JOIN
                         branch ON deliveryReceipt.branchNo = branch.branchNo
                         WHERE deliveryReceipt.AccountNo LIKE '%' + @accountno + '%'";
                var a = conn.Query<Models.DeliveryReceipt>(query, new { accountno = accountNo }).ToList();
                return a;
            }
        }


        public void UpdatePrimaryInstallment(string downPayment, string pn, string balance, string lcp, string orAMt, string orNumber, string drDetailsId)
        {
            adapter2.UpdateQueryPrimaryInstallment(downPayment, pn, balance, lcp, orAMt, orNumber, drDetailsId);
        }
    }
}
