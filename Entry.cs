//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SwimmingPool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entry
    {
        public int Number { get; set; }
        public string MemberID { get; set; }
        public Nullable<System.DateTime> checkIn { get; set; }
        public Nullable<int> MembershipType { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual Membership Membership { get; set; }
    }
}
