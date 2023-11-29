// Création de plusieurs voiture
using Surcharge_operateur.models;

Voiture voiture1 = new Voiture()
{
    Marque = "toyota",
    Modele = "yaris",
    Annee = 2019,
    CapaciteCoffre = 286
};

Voiture voiture2 = new Voiture()
{
    Marque = "Honda",
    Modele = "Civic",
    Annee = 2020,
    CapaciteCoffre = 410
};


Console.WriteLine($"La capacité du coffre de la {voiture1.Marque} ainsi que de la {voiture2.Marque} sont de {voiture1+voiture2} L");

Console.WriteLine($"La capacité du coffre de la {voiture1.Marque} ainsi que de la {voiture2.Marque} sont de {voiture1 + voiture2.CapaciteCoffre} L");