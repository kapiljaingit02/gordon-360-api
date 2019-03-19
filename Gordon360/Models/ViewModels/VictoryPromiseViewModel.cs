using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gordon360.Models.ViewModels
{
    public class VictoryPromiseViewModel
    {
        // a separate int for each score
        public int Im { get; set; } // Intellectual Maturity 
        public int Cc { get; set; } // Christian Character
        public int Ls { get; set; } // Lives of Service
        public int Lw { get; set; } // Leadership Worldwide
    }
}