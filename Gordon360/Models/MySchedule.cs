﻿
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

    public partial class MYSCHEDULE
    {

        public string EVENT_ID { get; set; }

        public string GORDON_ID { get; set; } //should this really be a string? or an int?

        public string LOCATION { get; set; }

        public string DESCRIPTION { get; set; }

        public string MON_CDE { get; set; }

        public string TUE_CDE { get; set; }

        public string WED_CDE { get; set; }

        public string THU_CDE { get; set; }

        public string FRI_CDE { get; set; }

        public string SAT_CDE { get; set; }

        public string SUN_CDE { get; set; }

        public int IS_ALLDAY { get; set; }

        public System.TimeSpan BEGIN_TIME { get; set; }

        public System.TimeSpan END_TIME { get; set; }
        
}

}