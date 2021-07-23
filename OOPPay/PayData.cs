using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPay
{
    /// <summary>
    /// 交易資料
    /// </summary>
    public class PayData
    {
        private string _Time { get;  set; }

        private decimal _Money { get;  set; }

        private string _PaySource { get;  set; }

        private List<string> _PayList { get;  set; }

        public void SetTime(string date)
        {
            _Time = date;
        }

        public void SetMoney(decimal money)
        {
            _Money = money;
        }

        public void SetPaySource(string paysource)
        {
            _PaySource = paysource;
        }

        public void SetPayList(List<string> payList)
        {
            _PayList = payList;
        }

        public string GetTime()
        {
            return _Time;
        }

        public decimal GetMoney()
        {
            return _Money;
        }

        public string GetPaySource()
        {
            return _PaySource;
        }

        public List<string> GetPayList()
        {
            return _PayList;
        }
    }
}