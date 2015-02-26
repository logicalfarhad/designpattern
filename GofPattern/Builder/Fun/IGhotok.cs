using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Fun
{
    public interface IGhotok
    {
        Patri Patri { get; set; }//getter and setter for our patri
        //Ghotoker kaj
        void GetBabarTaka();
        void GetEducationStatus();
        void DekhteKemon();
        void JobStatus();
        void GetMonManosikota();
    }
}
