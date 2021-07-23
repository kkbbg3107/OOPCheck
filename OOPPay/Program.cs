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
            data.SetPaySource(input);
            data.SetMoney(123);
            data.SetTime("2019/08/13");

            Choose(data);

            Console.ReadLine();
        }

        public static void Choose(PayData p)
        {
            Check check = new Check();

            if (p.GetPaySource() == "1")
            {
                
                check.setPay(new Card());
                check.Pay(p);
            }
            else if (p.GetPaySource() == "2")
            {
                check.setPay(new Cash());
                check.Pay(p);
            }
            else if (p.GetPaySource() == "3")
            {
                check.setPay(new Line());
                check.Pay(p);
            }
        } 
    }
}
