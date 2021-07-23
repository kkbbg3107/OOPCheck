using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPPay.Model;

namespace OOPPay
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請選擇輸入方式 按1:悠遊卡 按2:行動支付 按3:現金");
            var input = Console.ReadLine();
            PayData data = new PayData();
            List<string> paylist = new List<string>();
            paylist.Add("香蕉");
            data.SetPaySource(input);
            data.SetMoney(123);
            data.SetTime("2019/08/13");
            data.SetPayList(paylist);
            Choose(data);

            Console.ReadLine();
        }

        public static void Choose(PayData p)
        {
            Check check = new Check();


            Dictionary<string, object> d = new Dictionary<string, object>()
            {
                {"1", new Card()},
                {"2", new Line()},
                {"3", new Cash()},
            };

            IPay pay =(IPay)d[p.GetPaySource()];
            check.setPay(pay);
            check.Pay(p);

            //if (p.GetPaySource() == "1")
            //{

            //    check.setPay(new Card());
            //    check.Pay(p);
            //}
            //else if (p.GetPaySource() == "2")
            //{
            //    check.setPay(new Cash());
            //    check.Pay(p);
            //}
            //else if (p.GetPaySource() == "3")
            //{
            //    check.setPay(new Line());
            //    check.Pay(p);
            //}

        } 
    }
}
