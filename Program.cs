using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2012_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stagiaire s1 = new Stagiaire("karami", "loubna", "TSDM", 10, 10, 10); // 10
            //Stagiaire s2 = new Stagiaire("Jamal", "Youssef", "TSDM", 18, 18, 18); // 18
            //Stagiaire s3 = new Stagiaire("Ilham", "Fayrouz", "TSDM", 12, 13, 14); // 13         

            int choice;
            do
            {
                
                Console.WriteLine("Entrez 1 pour Afficher: ");
                Console.WriteLine("Entrez 2 pour Ajouter");
                Console.WriteLine("Entrez 3 pour Rechercher");
                Console.WriteLine("Entrez 4 pour Mofifier");
                Console.WriteLine("Entrez 5 pour Supprimer");
                Console.WriteLine("Entrez 6 pour Aficher la meilleure moyenne");
                Console.WriteLine("Entrez -1 Quittez");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.Clear(); Stagiaire.listDesStagiers.ForEach(Console.WriteLine); break;
                    case 2: Ajouter(); break;
                    case 3: Rechercher(); break;
                    case 4: Modifier(); break;
                    case 5: Supprimer();break;
                    case 6: MeilleureMoyenne(); break;
                }
                
            } while (choice != -1);
                              
        }
   
        static void Ajouter()
        {
            Console.Clear();
            Stagiaire s = new Stagiaire();
            Console.Write("Entree le nom: "); s.Nom = Console.ReadLine();
            Console.Write("Entree le prenom: "); s.Prenom = Console.ReadLine();
            Console.Write("Entree le filiere: "); s.Filiere = Console.ReadLine();
            Console.Write("Entree la premiere note: "); s.Note1 = double.Parse(Console.ReadLine());
            Console.Write("Entree la deuxieme note: "); s.Note2 = double.Parse(Console.ReadLine());
            Console.Write("Entree la troisieme note: "); s.Note3 = double.Parse(Console.ReadLine());
            Stagiaire.listDesStagiers.Add(s);
        }

        static void Rechercher()
        {
            Console.Clear();
            Console.WriteLine("Entrez le matricule pour Rechercher: ");
            int matr = int.Parse(Console.ReadLine());
            foreach (Stagiaire s in Stagiaire.listDesStagiers)
            {
                if (s.Matricule == matr)
                    Console.WriteLine(s.ToString());
            }
        }

        static void Modifier()
        {
            Console.Clear();
            Console.WriteLine("Entrez le matricule de staigiare pour Modifier: ");
            int matr = int.Parse(Console.ReadLine());
            foreach (Stagiaire s in Stagiaire.listDesStagiers)
            {
                if (s.Matricule == matr)
                {
                    Console.Write("Entree le nouveau nom: "); s.Nom = Console.ReadLine();
                    Console.Write("Entree le nouveau prenom: "); s.Prenom = Console.ReadLine();
                    Console.Write("Entree le nouveau filiere: "); s.Filiere = Console.ReadLine();
                    Console.Write("Entree la nouveau premiere note: "); s.Note1 = double.Parse(Console.ReadLine());
                    Console.Write("Entree la nouveau deuxieme note: "); s.Note2 = double.Parse(Console.ReadLine());
                    Console.Write("Entree la nouveau troisieme note: "); s.Note3 = double.Parse(Console.ReadLine());
                }
            }
        }

        static void Supprimer()
        {
            Console.Clear();
            Console.WriteLine("Entrez le matricule pour Supprimer: ");
            int matr = int.Parse(Console.ReadLine());
            foreach (Stagiaire s in Stagiaire.listDesStagiers.ToList())
            {
                if (s.Matricule == matr)
                    Stagiaire.listDesStagiers.Remove(s);
            }
        }

        static void MeilleureMoyenne()
        {
            Console.Clear();         
            Stagiaire.listDesStagiers.Sort();
            Stagiaire.listDesStagiers.Reverse();
            Console.WriteLine($"La meilleure moyenne est: {Stagiaire.listDesStagiers[0].Calculer()} de Stagiare {Stagiaire.listDesStagiers[0].Nom} {Stagiaire.listDesStagiers[0].Prenom}");
        }
    }
}
