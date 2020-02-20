using System;
using System.Collections.Generic;
using System.Text;

namespace gestiondesbanques
{
    class Compte
    {
      
        private int numero;
        private int solde;
        private Client proprietaire;
      
 



        public int getNumero()
        {
            return numero;
        }
        public int getSolde()
        {
            return solde;
        }
      
        public Client getProprietaire()
        {
            return proprietaire;
        }

        public Compte(Client proprietaire)
        {
           
            
            this.proprietaire = proprietaire;
        }
        public void Versement(int somme)
        {
            DateTime d = DateTime.Now;
            solde += somme;
            Console.Out.WriteLine("Opération bien effectuée");
            Console.Out.WriteLine(d);
        }

        public void Versement(Compte c, int somme)//virement
        {
            DateTime d = DateTime.Now;
            if (c.solde >= somme)
            {
                c.solde -= somme;
                solde += somme;
                Console.Out.WriteLine("Opération bien effectuée");
            }
            else
                Console.Out.WriteLine("Solde de compte insuffisant");
        }
        public void Retrait(int somme)
        {
            DateTime d = DateTime.Now;
            if (solde >= somme)
            {
                solde -= somme;
                Console.Out.WriteLine("Opération bien effectuée");
            }
            else
                Console.Out.WriteLine("Solde insuffisant");
        }
        public void Retrait(Compte c, int somme)    //    virement          
        {
            DateTime d = DateTime.Now;
            if (solde >= somme)
            {
                solde -= somme;
                c.solde += somme;
                Console.Out.WriteLine("Opération bien effectuée");
            }
            else
                Console.Out.WriteLine("Solde insuffisant");
        }

    
        public void Afficher()
        {
            Console.Out.WriteLine("************************");
            Console.Out.WriteLine("Solde de compte: " + solde);
            Console.Out.WriteLine("Propriétaire du compte : ");
            Console.Out.WriteLine("*************************");
            proprietaire.affichage();
            Console.Out.WriteLine("*************************");
          
        }
        public bool cloture(Compte c)
        {
            if (solde < 100)
            {
                Console.WriteLine("Vous devvez avoir une somme minumum de 100dh");
                return true;
            }

            else { return false; }
            }
        }
       
        
    }

