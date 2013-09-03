using System;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class VicePresident : Employee
    {
        private const int MAX_PURCHASE_APPROVAL = 100000;

        public VicePresident()
        {
            onPurchaseRequested += new OnPurchaseRequested(VicePresident_onPurchaseRequested);
        }

        private void VicePresident_onPurchaseRequested(Employee e, PurchaseRequest p)
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
            Console.WriteLine("Purchase Id : {0} Amount: {1} Approver: {2}", purchaseRequest.Item, purchaseRequest.Amount, "Vice President");
        }
    }
}