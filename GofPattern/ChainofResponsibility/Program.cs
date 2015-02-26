using System;
using ChainofResponsibility.Demo;

namespace ChainofResponsibility
{
    public class Program
    {
        private static IApprover CreateChain()
        {
            IApprover handler = new RequestHandler();
            IApprover approver1 = new TeamLeader();
            IApprover approver2 = new ProjectManager();
            IApprover approver3 = new ResourceManager();
            handler.NextApprover = approver1;
            approver1.NextApprover = approver2;
            approver2.NextApprover = approver3;
            return handler;
        }

        public static void Main(string[] args)
        {
            var employee = new Employee("Forhad", 7);

            IApprover handler = CreateChain();

            Response response = handler.Approve(employee);

            if (response == Response.Approved)
            {
                Console.WriteLine("Have A nice Journey Mr:{0}", employee.Name);
            }
            else if (response == Response.Denied)
            {
                Console.WriteLine("Sorry Mr:{0} We are busy now", employee.Name);
            }
            Console.ReadLine();
        }
    }
}
