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
    
    public partial class staff_timesheets_select_active_status_shifts_Result
    {
        public int id { get; set; }
        public int eml { get; set; }
        public string eml_description { get; set; }
        public System.DateTime shift_start_datetime { get; set; }
        public System.DateTime shift_end_datetime { get; set; }
        public decimal hours_worked { get; set; }
        public string shift_notes { get; set; }
        public decimal hourly_rate { get; set; }
        public int supervisor { get; set; }
        public int comp_supervisor { get; set; }
        public string status { get; set; }
        public string comments { get; set; }
    }
}
