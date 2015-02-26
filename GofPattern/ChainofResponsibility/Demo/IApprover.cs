namespace ChainofResponsibility.Demo
{
    public interface IApprover
    {
        Response Approve(Employee employee);
        IApprover NextApprover { get; set; }
    }
}
