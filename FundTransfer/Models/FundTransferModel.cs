using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundTransfer.Models
{
    public enum Mode
    {
        NEFT,RTGS
    }
    public class FundTransferModel
    {
        public long CustomerId { get; set; }
        public long FromAccountNo { get; set; }
        public long ToAccountNo { get; set; }
        public long Amount { get; set; }
        public string Remarks { get; set; }

        public Mode Mode { get; set; }


    }
}
