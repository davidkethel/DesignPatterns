using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
   public abstract class Employee
   {
       public Employee Supervisor { get; set; }

       public delegate void OnPurchaseRequested(Employee e, PurchaseRequest p);

       public event OnPurchaseRequested onPurchaseRequested = null;


       public void PurchaseRequested(Employee s, PurchaseRequest purchaseRequest)
       {
           if (onPurchaseRequested != null)
           {
               onPurchaseRequested(this, purchaseRequest);
           }
       }

       
       public abstract void ApprovePurchase(PurchaseRequest purchaseRequest);


       public void RequestPurchase(PurchaseRequest p)
       {
           PurchaseRequested(this, p);
       }

   }
}
