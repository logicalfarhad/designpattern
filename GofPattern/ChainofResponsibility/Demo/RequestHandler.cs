using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility.Demo
{
    public class RequestHandler : IApprover
    {
        public Response Approve(Employee employee)
        {
            return NextApprover.Approve(employee);
        }
        public IApprover NextApprover { get; set; }
    }
}
