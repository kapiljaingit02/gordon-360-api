﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gordon360.Models.ViewModels
{
    public class ChapelEventViewModel
    {
        public int ROWID { get; set; }
        public string CHBarEventID { get; set; }
        public string CHBarcode { get; set; }
        public string CHEventID { get; set; }
        public string CHCheckerID { get; set; }
        public DateTime CHDate { get; set; }
        public DateTime CHTime { get; set; }
        public string CHTermCD { get; set; }

        public static implicit operator ChapelEventViewModel(ChapelEvent a)
        {
            ChapelEventViewModel vm = new ChapelEventViewModel
            {
                ROWID = a.ROWID,
                CHBarEventID = a.CHBarEventID.Trim(),
                CHBarcode = a.CHBarcode.Trim(),
                CHEventID = a.CHEventID,
                CHCheckerID = a.CHCheckerID.Trim(),
                CHDate = a.CHDate.Add(a.CHTime.TimeOfDay),
                CHTime = a.CHTime,
                CHTermCD = a.CHTermCD.Trim(),
            };

            return vm;
        }
    }


}