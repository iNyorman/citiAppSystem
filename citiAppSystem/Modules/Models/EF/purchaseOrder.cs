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
    
    public partial class purchaseOrder
    {
        public int indexNo { get; set; }
        public string poID { get; set; }
        public Nullable<System.DateTime> poDate { get; set; }
        public Nullable<System.DateTime> deliveryDate { get; set; }
        public string sup_IDno { get; set; }
        public string branchNo { get; set; }
        public string approvedBy { get; set; }
        public string totalAmount { get; set; }
    }
}