namespace ChainofResponsibility.Demo
{
    public class TeamLeader : IApprover
    {
        public Response Approve(Employee employee)
        {
            if (employee.Days == 1)
                return Response.Approved;
            return NextApprover.Approve(employee);
        }

        public IApprover NextApprover { get; set; }
    }
}
