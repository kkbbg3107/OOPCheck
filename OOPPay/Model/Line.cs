using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPay.Model;

namespace OOPPay
{
    public class Line : IPay
    {
        public string PayMethod()
        {
            return "行動支付";
        }
    }
}
