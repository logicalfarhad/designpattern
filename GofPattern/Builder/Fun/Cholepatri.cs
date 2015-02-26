using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Fun
{
    public class KonoRokomPatri : IGhotok
    {
        public Patri Patri { get; set; }

        public KonoRokomPatri()
        {
            Patri = new Patri(PatriType.Chole);
        }
        public void GetBabarTaka()
        {
            Patri.BaperTake = "Puran Dhakar bebosayee";
        }

        public void GetEducationStatus()
        {
            Patri.EducationStatus = "Kono rokome metric pass dise";
        }

        public void DekhteKemon()
        {
            Patri.DekhteKemon = "Chaliye neya jabe";
        }

        public void JobStatus()
        {
            Patri.JobStatus = "???";
        }

        public void GetMonManosikota()
        {
            Patri.GetMonmanosikota = "Ottonto khut khute";
        }
    }
}
