using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public partial class AmazonShippingOrderlist
    {
        public string Orderno { get; set; }
        public string Ponumber { get; set; }
        public string LabelWeight { get; set; }
        public string Qty { get; set; }
        public string Dimension { get; set; }
    }
}