using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class CEO : Employee
    {
        private const int MAX_PURCHASE_APPROVAL = 1000000;

        public CEO()
        {
            onPurchaseRequested += new OnPurchaseRequested(CEO_onPurchaseRequested);
        }

        private void CEO_onPurchaseRequested(Employee e, PurchaseRequest p)
        {
            if (p.Amount < MAX_PURCHASE_APPROVAL)
            {
                ApprovePurchase(p);
            }
            else
            {
                if (Supervisor != null)
                {
                    Supervisor.PurchaseRequested(this, p);
                }
            }
        }

        public override void ApprovePurchase(PurchaseRequest purchaseRequest)
        {
            Console.WriteLine("Item : {0},  Amount: {1},  Approver: {2}", purchaseRequest.Item, purchaseRequest.Amount, "CEO");
        }
    }
}