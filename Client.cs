using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondesbanques
{
    class Client
    {

        private string cin;
        private string nom;
        private string prenom;
        private string datedenaissance;
        private string lieudenaissance;
        private string adresse;
        private string email;
        private string gsm;



        public string getnom()
        {
            return nom;
        }
        public string getcin()
        {
            return cin;
        }
        public string getprenom()
        {
            return prenom;
        }
        public string getadresse()
        {
            return adresse;
        }
        public string getdatedenaissance()
        {
            return datedenaissance;
        }
        public string getlieudenaissance()
        {
            return lieudenaissance;
        }
        public string getemail()
        {
            return email;
        }
        public string getgsm()
        {
            return gsm;
        }

        public Client(string cin, string nom, string prenom, string datedenaissancde, string lieudenaissance, string adresse, string email, string gsm)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.datedenaissance = datedenaissancde;
            this.lieudenaissance = lieudenaissance;
            this.adresse = adresse;
            this.email = email;
            this.gsm = gsm;
        }
      public void affichage()
        {
            Console.Out.WriteLine("CIN: " + cin);
            Console.Out.WriteLine("Nom: " + nom);
            Console.Out.WriteLine("Prénom: " + prenom);
            Console.Out.WriteLine("Date de naissance: " + datedenaissance);
            Console.Out.WriteLine("Lieu de naissance: " +  lieudenaissance);
            Console.Out.WriteLine("Adresse: " + adresse);
            Console.Out.WriteLine("Email: " + email);
            Console.Out.WriteLine("GSM: " + gsm);
        }


    }
}