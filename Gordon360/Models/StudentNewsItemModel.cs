using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gordon360.Models
{
    public class StudentNewsItemModel
    {
        public string subject { get; set; }
        public string news { get; set; }
        public DateTime time { get; set; }
        public string name { get; set; }
    }
}