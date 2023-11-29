using Indexeur.models;

// création de mon garage
Garage monGarage = new Garage();

// Création de plusieurs voiture
Voiture voiture1 = new Voiture()
{
    Marque = "toyota",
    Modele = "yaris",
    Annee = 2019
};

Voiture voiture2 = new Voiture()
{
    Marque = "Honda",
    Modele = "Civic",
    Annee = 2020
};

Voiture voiture3 = new Voiture()
{
    Marque = "Peugeot",
    Modele = "208",
    Annee = 2015
};

// ajout des voitures au garage
monGarage.AjouterVoiture(1,voiture1);
monGarage.AjouterVoiture(2, voiture2);
monGarage.AjouterVoiture(3, voiture3);

// Parcour de la liste via l'indexeur de la classe garage
Console.WriteLine($"Marque voiture a l'index 1 : {monGarage[1].Marque}");
Console.WriteLine($"Marque voiture a l'index 2 : {monGarage[2].Marque}");
Console.WriteLine($"Marque voiture a l'index 3 : {monGarage[3].Marque}");