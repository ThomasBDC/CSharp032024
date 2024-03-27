//Faire une application qui nous donne le département en fonction du numéro qu'on lui donne
string userWantsContinue;


do
{
    Console.WriteLine("Donne moi le numéro de département à tester");
    string reponse = Console.ReadLine();
    switch (reponse)
    {
        case "1":
            Console.WriteLine("Le département est :AIN");
            break;
        case "2":
            Console.WriteLine("Le département est :AISNE");
            break;
        case "3":
            Console.WriteLine("Le département est :ALLIER");
            break;
        case "4":
            Console.WriteLine("Le département est :ALPES-DE-HAUTE-PROVENCE");
            break;
        case "5":
            Console.WriteLine("Le département est :HAUTES-ALPES");
            break;
        case "6":
            Console.WriteLine("Le département est :ALPES-MARITIMES");
            break;
        case "7":
            Console.WriteLine("Le département est :ARDÈCHE");
            break;
        case "8":
            Console.WriteLine("Le département est :ARDENNES");
            break;
        case "9":
            Console.WriteLine("Le département est :ARIÈGE");
            break;
        case "10":
            Console.WriteLine("Le département est :AUBE");
            break;
        case "11":
            Console.WriteLine("Le département est :AUDE");
            break;
        case "12":
            Console.WriteLine("Le département est :AVEYRON");
            break;
        case "13":
            Console.WriteLine("Le département est :BOUCHES-DU-RHÔNE");
            break;
        case "14":
            Console.WriteLine("Le département est :CALVADOS");
            break;
        case "15":
            Console.WriteLine("Le département est :CANTAL");
            break;
        case "16":
            Console.WriteLine("Le département est :CHARENTE");
            break;
        case "17":
            Console.WriteLine("Le département est :CHARENTE-MARITIME");
            break;
        case "18":
            Console.WriteLine("Le département est :CHER");
            break;
        case "19":
            Console.WriteLine("Le département est :CORRÈZE");
            break;
        case "21":
            Console.WriteLine("Le département est :CÔTE-D'OR");
            break;
        case "22":
            Console.WriteLine("Le département est :CÔTES-D'ARMOR");
            break;
        case "23":
            Console.WriteLine("Le département est :CREUSE");
            break;
        case "24":
            Console.WriteLine("Le département est :DORDOGNE");
            break;
        case "25":
            Console.WriteLine("Le département est :DOUBS");
            break;
        case "26":
            Console.WriteLine("Le département est :DRÔME");
            break;
        case "27":
            Console.WriteLine("Le département est :EURE");
            break;
        case "28":
            Console.WriteLine("Le département est :EURE-ET-LOIR");
            break;
        case "29":
            Console.WriteLine("Le département est :FINISTÈRE");
            break;
        case "2A":
            Console.WriteLine("Le département est :CORSE-DU-SUD");
            break;
        case "2B":
            Console.WriteLine("Le département est :HAUTE-CORSE");
            break;
        case "971":
            Console.WriteLine("Le département est :GUADELOUPE");
            break;
        case "972":
            Console.WriteLine("Le département est :MARTINIQUE");
            break;
        case "973":
            Console.WriteLine("Le département est :GUYANE");
            break;
        case "974":
            Console.WriteLine("Le département est :LA RÉUNION");
            break;
        case "976":
            Console.WriteLine("Le département est :MAYOTTE");
            break;
        default:
            Console.WriteLine("Je ne connais pas ce département");
            break;
    }


    Console.WriteLine("");
    Console.WriteLine("Voulez-vous continuer (o/n) ?");
    userWantsContinue = Console.ReadLine();
} while (userWantsContinue == "o");

