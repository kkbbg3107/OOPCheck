using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPay.Model
{
    public class Card : IPay
    {
        public string PayMethod()
        {
            return "悠遊卡";
        }
    }
}
