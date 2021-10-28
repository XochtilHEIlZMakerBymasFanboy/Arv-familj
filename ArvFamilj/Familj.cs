using System;

namespace ArvFamilj
{
    public class Familj
    {        
        private string Adress;
        private string Postnummer;
        private string Ort;

        public Familj(string adress, string postnummer, string ort)
        {
            Adress = adress;
            Postnummer = postnummer;
            Ort = ort;
        }

        protected string GetFullAdress()
        {
            return $"{Adress}{Environment.NewLine}{Postnummer} {Ort}";
        }
    }
}