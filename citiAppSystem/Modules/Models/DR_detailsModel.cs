using citiAppSystem.Modules.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models
{
    public class DR_detailsModel
    {

        public DR_detailsModel()
        {

        }

        public DR_detailsModel(DeliveryReceiptDatasets.DR_detailsRow row)
        {
            if(row != null)
            {
                id = row.id;
                DR_Details_ID = row.DR_Details_ID;
                LCP = row.LCP;
                stockNo = row.stockNo;
                AccountNo = row.AccountNo;
                qnty = row.qnty;
                remarks = row.remarks;
                down_payment = row.down_payment;
                or_number = row.or_number;
                description = row.description;
                pStatus = row.pStatus;
                cash = row.pStatus;
                orAmt = row.orAmt;
                brand = row.brand;
                serialNo = row.serialNo;
                model = row.model;
                paymentType = row.paymentType;
                PN = row.PN;
                BalanceAF = row.BalanceAF;
                termsDR = row.termsDR;
            }
        }
        public int id { get; set; }
        public string DR_Details_ID { get; set; }
        public string LCP { get; set; }
        public string stockNo { get; set; }
        public string AccountNo { get; set; }
        public string qnty { get; set; }
        public string remarks { get; set; }
        public string down_payment { get; set; }
        public string or_number { get; set; }
        public string description { get; set; }
        public string pStatus { get; set; }
        public string cash { get; set; }
        public string orAmt { get; set; }
        public string brand { get; set; }
        public string serialNo { get; set; }
        public string model { get; set; }
        public string paymentType { get; set; }
        public string PN { get; set; }
        public string BalanceAF { get; set; }
        public string termsDR { get; set; }
    }
}
