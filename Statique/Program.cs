using Statique.models;

Voiture voiture = new Voiture()
{
    Marque = "Honda",
    Modele = "Civic",
    Annee = 2020,
    CapaciteCoffre = 410
};

Garage garage = new Garage();

garage.AjouterVoiture(1, voiture);

// Utilisation de ma prop static
Console.WriteLine($"Le nombre de voiture dans le garage est de : {Garage.NombreVehicules}");