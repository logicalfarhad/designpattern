using System;
using Builder.Builder;
using Builder.Fun;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var marriageAgency = new MarriageAgency(); // ম্যারেজ এজেন্সি হাজির । 

            IGhotok patrimaker = new SeirokomPatri(); //ঘটক মশাই সেই রকম পাত্রীর খোজ এনেছেন । 

            marriageAgency.SupplyPatri(patrimaker); // এজেন্সি সাপ্লাই দিয়েছেন সেই রকম পাত্রী 

           patrimaker.Patri.DisplayPatrirConfiguration(); // পাত্রীর যাবতীয় গুণাবলী পরখ করছেন পাত্রেয় মা । 


        }
    }
}
