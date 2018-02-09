using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MegaDesk_3_PattiJones
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public DateTime Date;

        public enum Delivery
        {
            [Description("3 days")]
            threeDays,
            [Description("5 days")]
            fiveDays,
            [Description("7 days")]
            sevenDays,
            [Description("14 days")]
            fourteenDays,
        }
    }
}
