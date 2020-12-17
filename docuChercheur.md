# Document pour les chercheurs 

## Designs Patterns utilisés
### Factory pattern
Factory est une "usine", dans notre projet on a deux factory : "CentralFactory" et "ConsumerFactory". La premiere factory va permettre de créer n'importe quel type de centrale et la seconde factory a le même but mais pour les consommateurs. L'intêret commun de ces facory est de simplifier la création de nouvelles instances des classes de centrales et de consommateurs. Pour créer une nouvelle instance, on va donc instancier le factory en indiquant comme premier paramètre le type de centrale souhaité. Le principe est le même pour instancier un nouveau consommateur.

### Observer Pattern
Dans notre cas, la classe observée est WeatherData. Son rôle est de prévenir les classes qui l'observent d'une mise à jour, ici il s'agit des changements de température et de la force du vent. Si on prend par exemple le cas de la classe CentralEolien, puisque on a souhaité que la météo a un impact sur sa production , on l'a définie comme observateur de la classe WeatherData (par une relation d'héritage).

## Recupérer des données 
### pour une centrale ...

Toutes nos classes représentant des centrales héritent de l'interface "ICentral" qui contient la méthode se type Sring "GetInfo()". De ce fait, il est possible pour chaque centrale de récupérer ses caractéristiques :production électrique, coût de production et quantité de CO2 émise en utilisant cette méthode.

### pour un consommateur ...
En appliqaunt le même principe que pour les consommateurs, on a une interface "IConsumer" contenant également une méthode de type String mais cette fois appellée "GetElectricalConsommation()". Tous les consommateurs héritent donc de cette interface, ce qui permet de récupérer la consommation électrique de chaque consommateur.

### Météo et Bourse



## Diagramme de classe
<img alt="PartieGauche" src="C:\Users\Nathan Buchin\Desktop\ECAM BAC 3\Software 1\POO project\Rapport Projet POO\classDiagramG.jpg">
<img alt="PartieDroite" src="C:\Users\Nathan Buchin\Desktop\ECAM BAC 3\Software 1\POO project\Rapport Projet POO\ClassDiagramD.jpg">
## Diagramme de séquence 
<img alt="seq1" src="C:\Users\Nathan Buchin\Desktop\ECAM BAC 3\Software 1\POO project\Rapport Projet POO\seq1.png">
<img alt="seq2" src="C:\Users\Nathan Buchin\Desktop\ECAM BAC 3\Software 1\POO project\Rapport Projet POO\seq2.png">
