using System.Collections.Generic;
using System;

namespace ArvFamilj
{
    public class Familjemedlem : Familj
    {
        public int Alder { get; private set; }
        public Kon Kon { get; private set; }
        string Fornamn;
        string Efternamn;
        public string Personnummer { get; private set; }
        public string FullName => Fornamn + " " + Efternamn;
        public Familjemedlem(string adress, string postnummer, string ort, int alder, Kon kon, string fornamn, string efternamn, string personnummer) : base (adress, postnummer, ort)
        {
            Alder = alder;
            Kon = kon;
            Efternamn = efternamn;
            Fornamn = fornamn;
            Personnummer = personnummer;
        }

        public string GetAdress() 
        {
            return $"{FullName}{Environment.NewLine}{GetFullAdress()}{Environment.NewLine}";
        }
        public string SocailSecurityInformation()
        {
            return $"Namn:{FullName}{Environment.NewLine}Ålder:{Alder}{Environment.NewLine}Personnummer:{Personnummer}{Environment.NewLine}";
        }

    }
}