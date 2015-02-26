using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Fun
{
    public class Patri
    {
        private readonly PatriType _patriType;

        public string BaperTake { get; set; }
        public string EducationStatus { get; set; }
        public string DekhteKemon { get; set; }
        public string JobStatus { get; set; }
        public string GetMonmanosikota { get; set; }
           public Patri(PatriType patriType)
        {

            _patriType = patriType;
        }


        public void DisplayPatrirConfiguration()
        {
            Console.WriteLine("Patri Type:" + _patriType);
            Console.WriteLine("Baper Taka:" + BaperTake);
            Console.WriteLine("Education Status:" + EducationStatus);
            Console.WriteLine("Dekhte Kemon:" + DekhteKemon);
            Console.WriteLine("Job Status:" + JobStatus);
            Console.WriteLine("Mon Manosikota:" + GetMonmanosikota);
        }


    }
}
