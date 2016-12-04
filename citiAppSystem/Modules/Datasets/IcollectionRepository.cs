using citiAppSystem.Modules.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Datasets
{
    public interface IcollectionRepository
    {
        CollectionDatasets.collection_detailsDataTable CollectionDetailsTb();

        int CollectionDetailsCount();
        List<CollectionDatasets.collection_detailsRow> CollectionDetails(string collectionId);

        CollectionDatasets.collectionDataTable CollectionById(string collectionId);

        CollectionDatasets.collection_detailsDataTable CollectionDetailsTbByCollectionId(string collectionId);

        CollectionDatasets.collection_detailsRow CollectionDetailsInstallmentPayment(string collectionId);

        CollectionDatasets.collection_detailsRow GetDetailsByAccountNoAndOr(string accountNo, string OR);

        CollectionDatasets.collection_detailsRow CollectionDetailstLastPaymentDetail(string collectionId);


        void CollectionInsert(CollectionDatasets.collectionRow o);

        void CollectionDetailsInsert(Collection_Details o);

        void UpdateCollection(CollectionDatasets.collectionRow o);

        void DeleteCollectionDetailsByAccountNo(string accountNo);

        void UpdateCollectionDetailsByInstallment(string orNo,string grsamnt, string netamt, string interest,string rebate, string discount, string balance, string paymentType, string cash_amount,string cheque_amount, string date, string remarks, string collection_details_id);

        CollectionDatasets.collection_detailsRow LatestCollectionDetails();
    }
}
