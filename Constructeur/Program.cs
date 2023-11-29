using Constructeur.models;

Moto moto = new Moto("Yamaha", 1998, 3);

moto.AfficherDetail();

Voiture voitureSansCouleur = new Voiture("Honda", 1992, "Civic", 200);

voitureSansCouleur.AfficherDetail();

Voiture voitureAvecCouleur = new Voiture("Toyota", 2000, "Corolla", 200, "Noir");

voitureAvecCouleur.AfficherDetail();