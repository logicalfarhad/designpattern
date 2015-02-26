using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility.Demo
{
    public class ProjectManager : IApprover
    {
        public Response Approve(Employee employee)
        {
            if (employee.Days <= 3 && employee.Days >= 1)
                return Response.Approved;
            return NextApprover.Approve(employee);
        }
        public IApprover NextApprover { get; set; }
    }
}
