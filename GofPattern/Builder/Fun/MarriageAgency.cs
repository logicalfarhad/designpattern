namespace Builder.Fun
{
    public class MarriageAgency
    {
        public void SupplyPatri(IGhotok patribuilder)
        {
            patribuilder.GetMonManosikota();
            patribuilder.GetBabarTaka();
            patribuilder.DekhteKemon();
            patribuilder.GetEducationStatus();
            patribuilder.JobStatus();
            patribuilder.GetMonManosikota();
        }
    }
}