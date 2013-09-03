using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class PurchaseRequest
    {
        public int Amount { get; set; }

        public string Item { get; set; }

        public PurchaseRequest(String item, int amount)
        {
            Item = item;
            Amount = amount;
        }
    }
}
