using System;

namespace gestiondesbanques
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.Out.WriteLine("Compte 1: ");

            string cin, nom, prenom, datedenaissance, lieudenaissance, adresse, email, gsm;

            Console.WriteLine("entrez votre CIN: ");
            cin = Console.ReadLine();
            Console.WriteLine("entrez votre Nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("entrez votre Prénom: ");
            prenom = Console.ReadLine();
            Console.WriteLine("entrez votre Date de naissance: ");
            datedenaissance = Console.ReadLine();
            Console.WriteLine("entrez votre Lieu de naissance : ");
            lieudenaissance = Console.ReadLine();
            Console.WriteLine("Donner votre email: ");
            email = Console.ReadLine();
            Console.WriteLine("entrez votre adresse: ");
            adresse = Console.ReadLine();
            Console.WriteLine("Donner votre gsm: ");
            gsm = Console.ReadLine();


            Compte C1 = new Compte(new Client(cin, nom, prenom, datedenaissance, lieudenaissance, adresse, email, gsm));
            Console.WriteLine("Détails du compte: ");
            C1.Afficher();

            int choixC = 0 ;
            Console.WriteLine("choisissez le type de compte :");
            Console.WriteLine("pour le compte courant tapez 1");
            Console.WriteLine("pour le compte epargne tapez 2");
            choixC = System.Convert.ToInt32(Console.ReadLine());

            if (choixC == 1)
            {
                int montant;
                bool encours = true;
                while (encours)
                {
                    Console.WriteLine("Merci de selectionner une operation: ");
                    Console.WriteLine("  pour L'operation Versement tapez 1  ");
                    Console.WriteLine(" pour L'operation Retrait tapez 2  ");
                    Console.WriteLine(" pour L'operation Paiment par carte tapez 3  ");
                    Console.WriteLine(" pour L'operation Paiment par internet tapez 4  ");
                    Console.WriteLine(" pour L'operation Virement tapez 5  ");
                    Console.WriteLine(" pour quitter tapez 6  ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Versement");
                            Console.Out.Write("Donner le montant à déposer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                            C1.Versement(montant);
                            C1.Afficher();

                            break;
                        case "2":
                            Console.WriteLine("Retrait");
                            Console.Out.Write("Donner le montant à retirer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                            C1.Retrait(montant);
                            C1.Afficher();
                            break;
                        case "3":
                            Console.WriteLine("Paiment par carte");
                            Console.Out.Write("Donner le montant à payer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                            C1.Retrait(montant);
                            C1.Afficher();

                            break;
                        case "4":
                            Console.WriteLine("Paiment par internet");
                            Console.Out.Write("Donner le montant à payer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                            C1.Retrait(montant);
                            C1.Afficher();

                            break;
                        case "5":
                            Console.WriteLine("virement");
                            Console.Out.WriteLine("\n\nCompte 2: ");
                            Console.WriteLine("entrez votre CIN: ");
                            cin = Console.ReadLine();
                            Console.WriteLine("entrez votre Nom: ");
                            nom = Console.ReadLine();
                            Console.WriteLine("entrez votre Prénom: ");
                            prenom = Console.ReadLine();
                            Console.WriteLine("entrez votre Date de naissance: ");
                            datedenaissance = Console.ReadLine();
                            Console.WriteLine("entrez votre Lieu de naissance : ");
                            lieudenaissance = Console.ReadLine();
                            Console.WriteLine("Donner votre email: ");
                            email = Console.ReadLine();
                            Console.WriteLine("entrez votre adresse: ");
                            adresse = Console.ReadLine();
                            Console.WriteLine("Donner votre gsm: ");
                            gsm = Console.ReadLine();

                            Compte C2 = new Compte(new Client(cin, nom, prenom, datedenaissance, lieudenaissance, adresse, email, gsm));
                            Console.WriteLine("Détails du compte: ");
                            C2.Afficher();
                            Console.Out.WriteLine("faire un virement dans le deuxieme compte  à partir du premier compte ");
                            Console.Out.Write("Donner le montant à déposer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                            C2.Versement(C1, montant); 
                            C1.Afficher();
                            C2.Afficher();
                            break;
                        case "6":
                            Console.WriteLine("Quitter");
                            encours = false;
                            break;
                        default:
                            Console.WriteLine("Numero inexistant");
                            break;

                    }
                }







            }
            else if (choixC==2)
            { 
                
                int montant;
                
                bool encours = true;
                while (encours)

                {
                    Console.WriteLine("Merci de selectionner une operation: ");
                    Console.WriteLine(" pour L'operation Versement tapez 1  ");
                    Console.WriteLine(" pour L'operation Retrait tapez 2  ");
                    Console.WriteLine(" pour quitter tapez 3 ");
                    switch (Console.ReadLine())
                    {
                         
                        case "1":
      
                            Console.WriteLine("Versement");
                            Console.Out.Write("Donner le montant à déposer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                           
                            C1.Versement(montant);
                            C1.Afficher();

                          



                            break;
                        case "2":
                            if (C1.cloture(C1))

                            {
                                break;
                            }
                            Console.WriteLine("Retrait");
                            Console.Out.Write("Donner le montant à retirer: ");
                            montant = Convert.ToInt32(Console.ReadLine());
                          
                            C1.Retrait(montant);
                            C1.Afficher();
                            break;
                        case "3":
                            Console.WriteLine("Quitter");
                            encours = false;
                            break;
                        default:
                            Console.WriteLine("Numero inexistant");
                            break;

                    }


                }
            }
        }
    }
}
                    
            
            


            

