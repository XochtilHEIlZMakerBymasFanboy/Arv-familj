using System;
using System.Collections.Generic;
using System.Linq;

namespace ArvFamilj
{
    class Program
    {
        static List<Familjemedlem> familjemedlemmar = new List<Familjemedlem>();
        static void Main(string[] args)
        {
            familjemedlemmar.Add(new Familjemedlem("Vilkebacken 100", "692 36", "Hälsingborg", 19312, Kon.Kvinna, "Jelly", "Jojo", "478219"));
            familjemedlemmar.Add(new Familjemedlem("Vilkebacken 100", "692 36", "Hälsingborg", 666835, Kon.Man, "Ulex", "youtube", "09876"));
            familjemedlemmar.Add(new Familjemedlem("Vilkebacken 100", "692 36", "Hälsingborg", 5, Kon.Kvinna, "Lolo", "Lulu", "654785"));
            familjemedlemmar.Add(new Familjemedlem("Vilkebacken 100", "692 36", "Hälsingborg", 5433, Kon.Man, "hohoho", "Jojo", "345345"));
            GetFamiljemedlem("478219");
            GetFamiljemedlem(5, Kon.Kvinna);
            GetFamiljemedlem(Kon.Man);
        }

        private static void GetFamiljemedlem(string personnnumer)
        {
            var medlem = familjemedlemmar.FirstOrDefault(x => x.Personnummer == personnnumer);
            if (medlem != null)
                Console.WriteLine(medlem.GetAdress());
            else
                Console.WriteLine("Hittades ej");
        }

        private static void GetFamiljemedlem(int alder, Kon kon)
        {
            var medlem = familjemedlemmar.FirstOrDefault(x => x.Alder == alder && x.Kon == kon);
            if(medlem != null)
                Console.WriteLine(medlem.SocailSecurityInformation());
            else
                Console.WriteLine("Hittades ej");
        }

        private static void GetFamiljemedlem(Kon kon)
        {
            var medlemar = familjemedlemmar.Where(x => x.Kon == kon);
            foreach(var medlem in medlemar)
                Console.WriteLine(medlem.GetAdress()); 

        }
    }
}
