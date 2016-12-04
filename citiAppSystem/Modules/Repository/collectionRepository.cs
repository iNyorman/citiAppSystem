using citiAppSystem.Modules.Datasets.CollectionDatasetsTableAdapters;
using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using citiAppSystem.Modules.Models;

namespace citiAppSystem.Modules.Repository
{
    public class collectionRepository : IcollectionRepository
    {
        collectionTableAdapter colAdapter = new collectionTableAdapter();
        collection_detailsTableAdapter cDetailsAdapter = new collection_detailsTableAdapter();
        public List<CollectionDatasets.collection_detailsRow> CollectionDetails(string collectionId)
        {
            return cDetailsAdapter.GetDataByCollection_ID(collectionId).Cast<CollectionDatasets.collection_detailsRow>().ToList();
        }
        public CollectionDatasets.collectionDataTable CollectionById(string collectionId)
        {
            return colAdapter.GetDataByCollectionId(collectionId);
        }
        public CollectionDatasets.collection_detailsDataTable CollectionDetailsTbByCollectionId(string collectionId)
        {
            return cDetailsAdapter.GetDataByCollection_ID(collectionId);
        }

        public void CollectionInsert(CollectionDatasets.collectionRow o)
        {
            colAdapter.Insert(o.Collection_ID,
                              o.Total_LCP,
                              o.Payment,
                              o.Balance,
                              o.UDI,
                              o.Total_Rebate,
                              o.PN,o.GRS_Monthly,
                              o.Net_monthly,
                              o.Transaction_Date,
                              o.Notarial_Fee,
                              o.Delivery_Fee,
                              o.Other_Pay,
                              o.Status,
                              o.terms,
                              o.paymentType,
                              o.remarks,
                              o.monthlyRebate);
        }

        public void CollectionDetailsInsert(Collection_Details o)
        {
            cDetailsAdapter.Insert(o.Collection_Details_ID,
                                   o.Date,
                                   o.NO,
                                   o.OR_Number,
                                   o.PRIN_Amount,
                                   o.Total_Amount,
                                   o.Penalty,
                                   o.Rebate,
                                   o.Discount,
                                   o.Acct_Balance,
                                   o.transaction_date,
                                   o.Collection_ID,
                                   o.expected_date,
                                   o.expected_balance,
                                   o.paymentType,
                                   o.remarks,
                                   o.stockNo,
                                   o.coll_cash_amt,
                                   o.col_cheque_amt);
        }

        public CollectionDatasets.collection_detailsDataTable CollectionDetailsTb()
        {
            return cDetailsAdapter.GetData();
        }

        public int CollectionDetailsCount()
        {
            return (int)cDetailsAdapter.ScalarQuery();
        }


        public void UpdateCollection(CollectionDatasets.collectionRow o)
        {
            colAdapter.UpdateQuery(o.Total_LCP, o.Payment, o.Balance, o.UDI, o.Total_Rebate, o.PN, o.GRS_Monthly, o.Net_monthly, o.Notarial_Fee, o.Delivery_Fee, o.Other_Pay,  o.terms, o.monthlyRebate,o.Collection_ID);
        }

        public void DeleteCollectionDetailsByAccountNo(string accountNo)
        {
            cDetailsAdapter.DeleteQuery(accountNo);
        }


        public void UpdateCollectionDetailsByInstallment(string orNo, string grsamnt, string netamt, string interest,string rebate, string discount, string balance, string paymentType, string cash_amount, string cheque_amount, string date, string remarks, string collection_details_id)
        {
            cDetailsAdapter.UpdateQueryForInstallment(orNo,
                grsamnt,
                netamt,
                interest,
                rebate,
                discount,
                balance,
                paymentType,
                cash_amount,
                cheque_amount,
                date,
                remarks,
                collection_details_id
                );
        }


        public CollectionDatasets.collection_detailsRow LatestCollectionDetails()
        {
            return  cDetailsAdapter.GetDataByLatestRow().FirstOrDefault();
        }


        public CollectionDatasets.collection_detailsRow CollectionDetailsInstallmentPayment(string collectionId)
        {
            return cDetailsAdapter.GetDataByLatestInstallmentPayment(collectionId).FirstOrDefault();
        }


        public CollectionDatasets.collection_detailsRow CollectionDetailstLastPaymentDetail(string collectionId)
        {
            return cDetailsAdapter.GetDataByLastPaymentCollectionDetails(collectionId).FirstOrDefault();
        }


        public CollectionDatasets.collection_detailsRow GetDetailsByAccountNoAndOr(string accountNo, string OR)
        {
            return cDetailsAdapter.GetDataByAccountNoAndOR(accountNo, OR).FirstOrDefault();
        }
    }
}
