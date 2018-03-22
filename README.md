# socws1
First lab for Service Oriented Computing and Web Service

## Extensions choisies
1. MVP - faire un IWS (Intermediate Web Service) qui propose une API SOAP et qui fait des appels au WS Velib + client console.
2. GUI - Client IWS
  * Executer le projet "Client IWS" pour avoir un apercu de la GUI developee.
  * Au lancement, on a des boutons sur la gauche pour:
    * Afficher la liste des villes,
    * Afficher la liste des stations associees,
    * Afficher le nombre de velos disponibles pour la station choisie,
    * Afficher plus de details sur la station choisie,
  * Affichage de la MAP pour voir ou est situee la station choisie
  * Affichage du recapitulatif des stations/villes choisies
3. Utilisation du cache pour reduire le temps d'execution des appels des methodes de l'API du IWS par le client.
  * Dans l'implementation des methodes du IWS, quand je fais un appel sur une fonction de l'API Velib, je creer un cache avec une clef qui correspond a ce qu'on a choisi (ex: listCities, listStationsForCity...) et ce cache se refresh au bout de 5 minutes mais on peut le changer dans le code.
  * Les effets sont que, cote client, quand on fait 2 fois un meme appel a l'API d'IWS, on voit que le temps d'execution est beaucoup plus rapide.
  * Pour voir cela, j'ai mis un indicateur qui donne le temps d'execution des appels a IWS sur le client IWS.
4. Developpement d'un nouveau service pour le monitoring + client de monitoring
  * Le service a pour contrat IMonitorService et est implemente dans la classe MonitorService.
  * Les fonctionnalites que propose le service de monitoring:
    * Avoir le nombre d'appel (client) des methodes de l'IWS
    * Avoir le nombre d'appel d'IWS au service de Velib
    * Avoir le nombre de clients qui sont connecte
    * Le temps d'execution moyen des fonctions (pour montrer que grace a l'utilisation de cache, la moyenne tend a se stabiliser)
  * Client de monitoring, on peut:
    * Soit mettre a jour les graphs manuellement en appuyant sur le bouton en haut a droite,
    * Soit faire un auto-refresh pour mettre a jour les graphs en cochant la case auto-refresh, cela automatisera et on peut ensuite laisser le client de monitoring tourner en fond. Toutes les 10 secondes on update les graphs (cela peut etre modifie bien sur dans le code)
