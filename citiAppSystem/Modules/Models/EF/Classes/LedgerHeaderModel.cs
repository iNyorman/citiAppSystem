using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models.EF.Classes
{
    public class LedgerHeaderModel
    {
        public LedgerHeaderModel()
        {

        }
        public LedgerHeaderModel(deliveryReceipt dr, collection collection,customerTable customer)
        {
            this.AccountNo = dr.AccountNo;
            this.CustomerName = customer.fullName;
            this.CustomerAddress = customer.address;
            this.Employer = customer.employer;
            this.EmployerAddress = customer.employerAddress;
            this.CoMaker = customer.co_Maker;
            this.ComakerAddress = customer.co_MakerAddress;
            this.TotalPayment = collection.Total_LCP;
            this.DownPayment = collection.Payment;
            this.Balance = collection.Balance;
            this.UDI = collection.UDI;
            this.TotalRebate = collection.Total_Rebate;
            this.PN = collection.PN;
            this.Terms = collection.terms;
            this.GRS_Monthly = collection.GRS_Monthly;
            this.NetMonthly = collection.Net_monthly;
            this.DeliveryDate = dr.Delivery_Date.Value.ToShortDateString();
            if(dr.DRtype != "DR")
            {
               this.SI_DR_No = dr.SI_DR_no;
            }
            else
            {
                this.SI_DR_No = dr.DR_no;
            }
            this.Salesman = dr.Salesman;
            this.CIBY = dr.CI_By;
        }

        public string AccountNo { get; set; }
        public string  CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Employer { get; set; }
        public string  EmployerAddress { get; set; }
        public string CoMaker { get; set; }
        public string ComakerAddress { get; set; }
        public string TotalPayment { get; set; }
        public string DownPayment { get; set; }
        public string Balance { get; set; }
        public string UDI { get; set; }
        public string TotalRebate { get; set; }
        public string PN { get; set; }
        public string Terms { get; set; }
        public string GRS_Monthly { get; set; }
        public string MonthlyRebate { get; set; }
        public string NetMonthly { get; set; }
        public string DeliveryDate { get; set; }
        public string SI_DR_No { get; set; }
        public string Salesman { get; set; }
        public string CIBY { get; set; }
    }
}
