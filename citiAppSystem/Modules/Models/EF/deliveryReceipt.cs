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
    
    public partial class deliveryReceipt
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string Account_Type { get; set; }
        public Nullable<System.DateTime> Delivery_Date { get; set; }
        public string SI_DR_no { get; set; }
        public string Salesman { get; set; }
        public string CI_By { get; set; }
        public string ID_Number { get; set; }
        public string Collection_ID { get; set; }
        public string Status { get; set; }
        public string branchNo { get; set; }
        public string DR_no { get; set; }
        public string DRtype { get; set; }
    }
}
