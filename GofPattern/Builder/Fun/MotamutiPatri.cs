using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Fun
{
    public class MotamutiPatri : IGhotok
    {
        public Patri Patri { get; set; }
        public void GetBabarTaka()
        {
            Patri.BaperTake = "Motamuti borolok";
        }

        public void GetEducationStatus()
        {
            Patri.EducationStatus = "Inter pass dise";
        }

        public void DekhteKemon()
        {
            Patri.DekhteKemon = "Motamuti dekhte";
        }

        public void JobStatus()
        {
            Patri.JobStatus = "Job kore na";
        }

        public void GetMonManosikota()
        {
            Patri.GetMonmanosikota = "saradin sajuguju kore ar star jolsa dekhe";
        }
    }
}
