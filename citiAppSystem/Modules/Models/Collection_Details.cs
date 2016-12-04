using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiAppSystem.Modules.Models
{
    public class Collection_Details
    {
        public int id { get; set; }
        public string Collection_Details_ID { get; set; }
        public string NO { get; set; }

        public string OR_Number { get; set; }
        public string PRIN_Amount { get; set; }
        public string Total_Amount { get; set; }
        public string Penalty { get; set; }
        public string Rebate { get; set; }
        public string Discount { get; set; }
        public string Acct_Balance { get; set; }
        public string Collection_ID { get; set; }
        public string expected_balance { get; set; }
        public string paymentType { get; set; }
        public string remarks { get; set; }
        public string stockNo { get; set; }
        public DateTime? transaction_date { get; set; }
        public DateTime? expected_date { get; set; }
        public string coll_cash_amt { get; set; }
        public string col_cheque_amt { get; set; }
        public DateTime? Date { get; set; }
    }
}
