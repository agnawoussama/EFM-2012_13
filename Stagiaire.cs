using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2012_13
{
    class Stagiaire : IComparable<Stagiaire>
    {
        //attributs
        int matricule;
        string nom;
        string prenom;
        string filiere;
        Double note1;
        Double note2;
        Double note3;
        public static int nombreStagieres;
        public static List<Stagiaire> listDesStagiers = new List<Stagiaire>();

        //proprietes
        public int Matricule  { get { return matricule; } set { matricule = value; } }
        public string Nom     { get { return nom;       } set { nom       = value; } }
        public string Prenom  { get { return prenom;    } set { prenom    = value; } }
        public string Filiere { get { return filiere;   } set { filiere   = value; } }
        public Double Note1   { get { return note1;     } set { note1     = value; } }
        public Double Note2   { get { return note2;     } set { note2     = value; } }
        public Double Note3   { get { return note3;     } set { note3     = value; } }

        //Constructeur sans parametrer
        public Stagiaire()
        {
            nombreStagieres++;
            matricule = nombreStagieres;
        }

        //Constructeur modifie
        public Stagiaire(string nom, string prenom,string filiere)
        {
            nombreStagieres++;
            matricule = nombreStagieres;
            this.nom = nom;
            this.prenom = prenom;
            this.filiere = filiere;
        }

        //Constructeur d'initialisation
        public Stagiaire(string nom,string prenom,string filiere,Double note1,Double note2,Double note3)
        {
            nombreStagieres++;
            matricule = nombreStagieres;
            this.nom = nom;
            this.prenom = prenom;
            this.filiere = filiere;
            this.note1 = note1;
            this.note2 = note2;
            this.note3 = note3;
        }

        //Methode qui instance le compteur a zero
        public void RAZ() { nombreStagieres = 0; }

        //Methode Equals (par nom)
        public override bool Equals(object obj)
        {
            Stagiaire s = obj as Stagiaire;
            if (nom == s.nom) return true;
            else return false;    
        }
        double moyenne;
        //Methode qui calcule la moyenne generale d'etudiants
        public double Calculer()
        {
            moyenne = (note1 + note2 + note3) / 3;
            return moyenne; 
        }

        //ToString overriden
        public override string ToString()
        {
            double m = Calculer();
            return $"Matricule: {Matricule}\nNom: {Nom}\nPrenom: {Prenom}\nFiliere: {Filiere}\nNote1: {Note1}\nNote2: {Note2}\nNote3: {Note3}\nMoyenne {m}\n----------------";
        }

        //Implementation de l'interface IComparable
        public int CompareTo(Stagiaire other)
        {
            double moy = Calculer();
            if (moy > other.Calculer())
                return 1;
            else if (moy == other.Calculer())
                return 0;
            else return -1;
        }

        public static void SortDecroissant()
        {
            listDesStagiers.Sort();
            listDesStagiers.Reverse();
            listDesStagiers.ForEach(Console.WriteLine);
        }

        public static void SortCroissant()
        {
            listDesStagiers.Sort();
            listDesStagiers.ForEach(Console.WriteLine);
        }
    }
}
