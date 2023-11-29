using Generique.models;

#region Création de véhicules

#region Création de voiture électrique
voitureElectrique voitureMusk1 = new voitureElectrique()
{
    Annee = 2003,
    CapaciteBatterie = 100,
    Marque = "Tesla"
};

voitureElectrique voitureMusk2 = new voitureElectrique()
{
    Annee = 2009,
    CapaciteBatterie = 200,
    Marque = "Tesla"
};

voitureElectrique voitureMusk3 = new voitureElectrique()
{
    Annee = 2015,
    CapaciteBatterie = 400,
    Marque = "Tesla"
};
#endregion

#region Création de moto
Moto moto1 = new Moto()
{
    Annee = 1999,
    Marque = "Suzuki",
    AntiChute = false
};

Moto moto2 = new Moto()
{
    Annee = 2015,
    Marque = "Yamaha",
    AntiChute = true
};

Moto moto3 = new Moto()
{
    Annee = 2021,
    Marque = "Scooter",
    AntiChute = true
};
#endregion

#endregion

#region Gestion garage électrique
Garage<voitureElectrique> garageElectrique = new Garage<voitureElectrique>();

garageElectrique.AjouterVehicule(voitureMusk1);
garageElectrique.AjouterVehicule(voitureMusk2);
garageElectrique.AjouterVehicule(voitureMusk3);

Console.WriteLine("--- liste voiture électrique ---");
garageElectrique.AfficherDetailVehicule();
Console.WriteLine("---------------------------------");
#endregion


#region Gestion garage moto
Garage<Moto> garageMoto = new Garage<Moto>();

garageMoto.AjouterVehicule(moto1);
garageMoto.AjouterVehicule(moto2);
garageMoto.AjouterVehicule(moto3);

Console.WriteLine("---       Liste Moto        ---");
garageElectrique.AfficherDetailVehicule();
Console.WriteLine("---------------------------------");
#endregion