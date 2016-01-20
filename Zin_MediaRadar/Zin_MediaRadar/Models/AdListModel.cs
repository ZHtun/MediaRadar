using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zin_MediaRadar.Models
{
    public class AdListModel
    {
        public int AdId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ExtensionData { get; set; }
        public decimal NumPages { get; set; }
        public string Position { get; set; }

    }//class

}//namespace