using Polymorphisme.models;

// Casting implicite
Vehicule moto = new Moto();

// Casting explicite
object objet = new Moto();

Moto objet2 = (Moto)objet;

objet2.Fairevrombir();