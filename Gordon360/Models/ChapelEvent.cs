//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gordon360.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChapelEvent
    {
        public int ROWID { get; set; }
        public string CHBarEventID { get; set; }
        public int ID_NUM { get; set; }
        public string CHBarcode { get; set; }
        public string CHEventID { get; set; }
        public string CHCheckerID { get; set; }
        public Nullable<System.DateTime> CHDate { get; set; }
        public Nullable<System.DateTime> CHTime { get; set; }
        public string CHSource { get; set; }
        public string CHTermCD { get; set; }
        public Nullable<int> Attended { get; set; }
        public Nullable<int> Required { get; set; }
        public Nullable<int> LiveID { get; set; }
    }
}
