namespace CSharp032024
{
    //CLASSE
    public class Departement
    {
        //Constructeur
        public Departement(string numeroDepartement, string nomDepartement, int nbHabitants, bool domTom, int superficie)
        {
            NumeroDepartement = numeroDepartement;
            NomDepartement = nomDepartement;
            NbHabitants = nbHabitants;
            DomTom = domTom;
            Superficie = superficie;
        }

        //propriétés
        public string NumeroDepartement { get; set; }
        //propriétés
        public string NomDepartement { get; set; }
        //propriétés
        public int NbHabitants { get; set; }
        //propriétés
        public bool DomTom { get; set; }
        //propriétés
        public int Superficie { get; set; }

        public string GetInformationsDepartement()
        {
            return "Département : " + NomDepartement + "(" + NumeroDepartement + ")"+ " Nb Habitants :"+NbHabitants + " Superficie : "+Superficie;
        }

        //Ajouter une fonction retournant le nombre d'habitants au m2
    }
}
