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
    
    public partial class ChangesLog
    {
        public int Id { get; set; }
        public string changeType { get; set; }
        public string Details { get; set; }
        public Nullable<System.DateTime> dateChange { get; set; }
    }
}
