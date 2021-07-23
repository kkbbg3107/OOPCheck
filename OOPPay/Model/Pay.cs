using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPay.Model
{
    public class Check
    {
        private IPay _pay;

        public void setPay(IPay pay)
        {
            _pay = pay;
        }

        public void Pay(PayData p)
        {
            Console.WriteLine($"你使用了{_pay.PayMethod()}付款");
          
            Console.WriteLine($"付款資料: 金額:{p.GetMoney()}\n日期:{p.GetTime()}");
            foreach (var item in p.GetPayList())
            {
                Console.WriteLine($"明細:{item}");
            }
        }
    }
}
