using Event.models;

Voiture voiture = new Voiture();

voitureElectrique voitureElectrique = new voitureElectrique();

voitureElectrique.CapaciteBatterie = 100;

voitureElectrique.EffectuerTrajet();
//voitureElectrique.EffectuerTrajet();
//voitureElectrique.EffectuerTrajet();

Console.WriteLine($"Après trajet(s), il reste {voitureElectrique.CapaciteBatterie} % ");