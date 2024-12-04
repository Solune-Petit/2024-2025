<?php // code php qui décide de ce qu'il faut donner comme valeur à la variable Stemplate
//appel aux controller

// on ajoutera par la suite les require aux modeles

// récupération du chemin désiré
$uri = $_SERVER["REQUEST_URI"];
if ($uri == "/index.php" || $uri === "/pageAcceuil" || $uri == "/" || $uri == "/game") {
    // récupérer toutes les données des tables sql

    //-----------------------
    $title = "Page d'accueil";              //titre à afficher dans l'onglet de la page du navigateur
    $template = "Views/game.php";    //chemin vers la vue demandée
    require_once("Views/base.php");         //appel de la page de base qui sera remplie avec la vue demandée
}