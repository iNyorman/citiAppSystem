//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace citiAppSystem.Modules.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class c_TransTable
    {
        public int trans_Id { get; set; }
        public string trans_Type { get; set; }
        public string OR_NUM { get; set; }
        public Nullable<System.DateTime> trans_Date { get; set; }
        public string AccountNo { get; set; }
        public string GRS_AMT { get; set; }
        public string REBATE { get; set; }
        public string INT { get; set; }
        public string DISC { get; set; }
        public string NET_AMT { get; set; }
        public string pay_Type { get; set; }
        public string PAYMENT { get; set; }
        public string bank { get; set; }
        public string chequeNo { get; set; }
        public string cTransStatus { get; set; }
        public string change { get; set; }
        public string ID_Number { get; set; }
        public string branchNo { get; set; }
        public string cash_AMT { get; set; }
        public string cheque_AMT { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> system_Date { get; set; }

        public void NewTransaction()
        {

        }
    }
}
