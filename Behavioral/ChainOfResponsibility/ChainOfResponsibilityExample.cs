using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    static class ChainOfResponsibilityExample
    {

        public static void Run()
        {
            var teamLeader = new TeamLeader();
            var departmentHead = new DepartmentHead();
            var vicePresident = new VicePresident();
            var ceo = new CEO();
            
            teamLeader.Supervisor = departmentHead;
            departmentHead.Supervisor = vicePresident;
            vicePresident.Supervisor = ceo;
            

            teamLeader.RequestPurchase(new PurchaseRequest("3 Reams of Paper", 200));
            teamLeader.RequestPurchase(new PurchaseRequest("New Computer", 2300));
            teamLeader.RequestPurchase(new PurchaseRequest("New Server", 245400));

        }
    }
}
