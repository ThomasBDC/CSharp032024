using CSharp032024;
using System.Linq.Expressions;
using System.Reflection.Metadata;


#region Variables

//toto -> Objet
var toto = new Departement("00", "inconnu", 0, true, 0);


List<Departement> departements =
[
    new("01", "Ain", 638000, false, 5762),
    new("02", "Aisne", 533000, false, 7369),
    new("03", "Allier", 339000, false, 7373),
    new("04", "Alpes-de-Haute-Provence", 168000, false, 6925),
    new("05", "Hautes-Alpes", 141000, false, 5549),
    new("06", "Alpes-Maritimes", 1090000, false, 4299),
    new("07", "Ardèche", 329000, false, 5566),
    new("08", "Ardennes", 276000, false, 5229),
    new("09", "Ariège", 160000, false, 4890),
    new("10", "Aube", 315000, false, 6004),
    new("11", "Aude", 378000, false, 6139),
    new("12", "Aveyron", 287000, false, 8735),
    new("13", "Bouches-du-Rhône", 2030000, false, 5087),
    new("14", "Calvados", 693000, false, 5547),
    new("15", "Cantal", 145000, false, 5746),
    new("16", "Charente", 367000, false, 5959),
    new("17", "Charente-Maritime", 662000, false, 6864),
    new("18", "Cher", 312000, false, 7235),
    new("19", "Corrèze", 250000, false, 5857),
    new("21", "Côte-d'Or", 533000, false, 8763),
    new("22", "Côtes-d'Armor", 617000, false, 6876),
    new("23", "Creuse", 120000, false, 5564),
    new("24", "Dordogne", 423000, false, 9060),
    new("25", "Doubs", 543000, false, 5256),
    new("26", "Drôme", 522000, false, 6529),
    new("27", "Eure", 606000, false, 6040),
    new("28", "Eure-et-Loir", 445000, false, 5860),
    new("29", "Finistère", 928000, false, 6733),
    new("2A", "Corse-du-Sud", 158000, false, 4014),
    new("2B", "Haute-Corse", 180000, false, 4664),
    new("30", "Gard", 753000, false, 5852),
    new("31", "Haute-Garonne", 1370000, false, 6300),
    new("32", "Gers", 193000, false, 6257),
    new("33", "Gironde", 1630000, false, 10120),
    new("34", "Hérault", 1160000, false, 6224),
    new("35", "Ille-et-Vilaine", 1070000, false, 6776),
    new("36", "Indre", 228000, false, 6903),
    new("37", "Indre-et-Loire", 605000, false, 6101),
    new("38", "Isère", 1260000, false, 7437),
    new("39", "Jura", 260000, false, 4999),
    new("40", "Landes", 409000, false, 9243),
    new("41", "Loir-et-Cher", 332000, false, 6343),
    new("42", "Loire", 770000, false, 4783),
    new("43", "Haute-Loire", 230000, false, 4974),
    new("44", "Loire-Atlantique", 1400000, false, 6760),
    new("45", "Loiret", 687000, false, 6776),
    new("46", "Lot", 177000, false, 5220),
    new("47", "Lot-et-Garonne", 337000, false, 5386),
    new("48", "Lozère", 75000, false, 5167),
    new("49", "Maine-et-Loire", 824000, false, 7174),
    new("50", "Manche", 502000, false, 6027),
    new("51", "Marne", 581000, false, 8239),
    new("52", "Haute-Marne", 176000, false, 6218),
    new("53", "Mayenne", 309000, false, 5169),
    new("54", "Meurthe-et-Moselle", 736000, false, 5240),
    new("55", "Meuse", 193000, false, 6240),
    new("56", "Morbihan", 769000, false, 6827),
    new("57", "Moselle", 1050000, false, 6197),
    new("58", "Nièvre", 208000, false, 6815),
    new("59", "Nord", 2600000, false, 5743),
    new("60", "Oise", 824000, false, 5860),
    new("61", "Orne", 286000, false, 6104),
    new("62", "Pas-de-Calais", 1490000, false, 6653),
    new("63", "Puy-de-Dôme", 666000, false, 7970),
    new("64", "Pyrénées-Atlantiques", 710000, false, 7648),
    new("65", "Hautes-Pyrénées", 233000, false, 4464),
    new("66", "Pyrénées-Orientales", 480000, false, 4114),
    new("67", "Bas-Rhin", 1150000, false, 4750),
    new("68", "Haut-Rhin", 764000, false, 3525),
    new("69", "Rhône", 1870000, false, 3245),
    new("70", "Haute-Saône", 230000, false, 5367),
    new("71", "Saône-et-Loire", 564000, false, 8572),
    new("72", "Sarthe", 582000, false, 6208),
    new("73", "Savoie", 436000, false, 6029),
    new("74", "Haute-Savoie", 819000, false, 4388),
    new("75", "Paris", 2240000, false, 105),
    new("76", "Seine-Maritime", 1250000, false, 6271),
    new("77", "Seine-et-Marne", 1400000, false, 5916),
    new("78", "Yvelines", 1430000, false, 2284),
    new("79", "Deux-Sèvres", 385000, false, 5996),
    new("80", "Somme", 578000, false, 6170),
    new("81", "Tarn", 396000, false, 5753),
    new("82", "Tarn-et-Garonne", 259000, false, 3719),
    new("83", "Var", 1050000, false, 5985),
    new("84", "Vaucluse", 560000, false, 3567),
    new("85", "Vendée", 693000, false, 6727),
    new("86", "Vienne", 439000, false, 6990),
    new("87", "Haute-Vienne", 377000, false, 5526),
    new("88", "Vosges", 364000, false, 5874),
    new("89", "Yonne", 346000, false, 7427),
    new("90", "Territoire de Belfort", 143000, false, 609),
    new("91", "Essonne", 1290000, false, 1803),
    new("92", "Hauts-de-Seine", 1610000, false, 176),
    new("93", "Seine-Saint-Denis", 1630000, false, 236),
    new("94", "Val-de-Marne", 1410000, false, 245),
    new("95", "Val-d'Oise", 1230000, false, 1246),
    new("971", "Guadeloupe", 395000, true, 1628),
    new("972", "Martinique", 375000, true, 1128),
    new("973", "Guyane", 270000, true, 83534),
    new("974", "La Réunion", 858000, true, 2512),
    new("976", "Mayotte", 279000, true, 376),
    new("977", "Saint-Barthélemy", 10000, true, 25),
    new("978", "Saint-Martin", 35000, true, 53),
    new("984", "Terres Australes et Antarctiques Françaises", 0, true, 0),
    new("986", "Wallis-et-Futuna", 15000, true, 264),
    new("987", "Polynésie Française", 280000, true, 3521),
    new("988", "Nouvelle-Calédonie", 295000, true, 18575)
];
#endregion

#region Recherche de départements

do
{
    Console.WriteLine("Donne moi le numéro ou le nom du département à tester (pas d'espace, uniquement des tirets)");
    var departementSelected = getOtherDepartementInformation(Console.ReadLine());
    Console.WriteLine(departementSelected.GetInformationsDepartement());
    //Afficher le nombre d'habitants par m2

} while (getIfUserWantsToContinue());

#endregion

#region Nombre de lettres dans le nom d'un département

do
{
    Console.WriteLine("Maintenant donnez moi un numéro de département, et je vous donnerai le nombre de lettres du département");
    var departementSelected2 = getOtherDepartementInformation(Console.ReadLine());
    Console.WriteLine(departementSelected2 + "("+ departementSelected2.NomDepartement.Length+")");

} while (getIfUserWantsToContinue());

#endregion

#region Functions

//Si on donne le nom, on récupère le numéro
//Si on donne le numéro, on récupère le nom
Departement getOtherDepartementInformation(string request)
{
    foreach(var departement in departements)
    {
        if (request.ToLower() == departement.NumeroDepartement.ToLower() ||
            request.ToLower() == departement.NomDepartement.ToLower())
        {
            return departement;
        }
    }

    return null;
}

bool getIfUserWantsToContinue()
{
    Console.WriteLine("");
    Console.WriteLine("Voulez-vous continuer (o/n) ?");
    string reponseWantContinue = Console.ReadLine();

    if (reponseWantContinue == "o")
    {
        return true;
    }
    else
    {
        return false;
    }
}

#endregion