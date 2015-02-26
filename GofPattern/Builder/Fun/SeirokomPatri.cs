using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Fun
{
    public class SeirokomPatri : IGhotok
    {
        public Patri Patri { get; set; }
        public SeirokomPatri()
        {
            Patri = new Patri(PatriType.SeirokomValo);
        }
        public void GetBabarTaka()
        {
            Patri.BaperTake = "Industrialist babar ekmatro meye !!! R kisu bolar asey??";
        }
        public void GetEducationStatus()
        {
            Patri.EducationStatus = "NSU theke BBA korse";
        }
        public void DekhteKemon()
        {
            Patri.DekhteKemon = "8-10 jon piche piche ghure";
        }
        public void JobStatus()
        {
            Patri.JobStatus = "Jobb kore na Business kore";
        }
        public void GetMonManosikota()
        {
            Patri.GetMonmanosikota = "Mardanga Type er High heel atitude";
        }
    }
}
