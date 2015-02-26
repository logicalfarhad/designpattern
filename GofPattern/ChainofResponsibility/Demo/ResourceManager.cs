namespace ChainofResponsibility.Demo
{
    public class ResourceManager : IApprover
    {
        public Response Approve(Employee employee)
        {
            if (employee.Days >= 7)

                return Response.Approved;

            return NextApprover.Approve(employee);
        }
        public IApprover NextApprover { get; set; }
    }
}
