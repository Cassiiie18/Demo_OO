using class_prop.models;

Voiture voiture1 = new Voiture();

voiture1.Nom = "Honda";

Console.WriteLine("------- Avant définition de couleur --------");

voiture1.Description();

voiture1.DefinirCouleur("bleu");

Console.WriteLine("------- Après définition de couleur --------");

voiture1.Description();

