# Projet 3BA : POO : 18 décembre 2020

## Créer une plateforme : simulateur des réseaux électriques d'un pays 

La plateforme doit permettre de modéliser :  

1°) Différents type de centrale de production 

*    centrale au gaz : production flexible, 

*    centrale nucléaire : production constante, chère et lente à démarrer et à stopper, 

*    parc éolien : production dépendant de la météo pouvant être réduite en cas de besoin, 

*    centrale solaire : production dépendant de la météo ne pouvant pas être réduite, 

*    achat d'électricité à l'étranger, 

*    d'autres types de centrales devraient pouvoir être ajouter à l'avenir. 

  

Caractéristiques d’une centrale sur une période de temps déterminée : 

*    quantité d'énergie électrique produite 

*    coût de production (dépend du prix des combustibles) 

*    quantité de CO2 produite 

 

2°) Différents type de consommateurs d’énergie électrique 

* Ville, 

* Entreprise, 

* Vente d'électricité à l'étranger, 

* Dissipateur pour éviter les surcharges, 

* D'autres types de consommateurs devraient pouvoir être ajouter à l'avenir. 

 

Caractéristiques d’un consommateur sur une période de temps déterminée : 

* Quantité d’énergie électrique  

* Prix pour cette quantité d’énergie électrique 

 

3°) L’infrastructure du réseau composée :  

* de lignes électriques : caractérisées par la puissance maximale qu'elles peuvent véhiculer, 

* De nœuds de concentration : recevant de l'énergie de plusieurs lignes et l'envoyant sur une ligne de sortie, 

* De nœuds de distribution : recevant de l'énergie d'une ligne et la distribuant entre plusieurs lignes de sorties dans des proportions contrôlable. 

* Les centrales et les consommateurs ne sont reliés qu'à une seule ligne. 

 


La plateforme devra pouvoir s'interfacer avec :

* une plateforme de simulation météo pouvant donner : le niveau d'ensoleillement, la force du vent et la température pour un point géographique donné

* une plateforme de simulation des marchés pouvant donner à chaque instant les prix d'achat et de vente d'électricité à l'étranger et les prix des combustibles


La plateforme devra permettre aux chercheurs:

* de construire un réseaux,
* d'implémenter les différents type de centrale et de consommateur,
* d'implémenter une simulation de météo,
* d'implémenter une simulation des marchés,
* d'implémenter un centre de contrôle permettant d'agir sur la production
des centrales et sur la distribution des noeuds de distribution.
* d'obtenir le coût de production, les revenus et la quantité de CO2
produite à chaque seconde.
* d'obtenir des messages d'alerte: lignes surchargées, surproduction, sous-production, blackout, ...

  
## Rediger un rapport contenant :
* un diagramme de classe
* un diagramme de séquence
* une documentation a destination des chercheurs
 

 
