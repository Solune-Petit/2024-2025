<?php 

require_once("./models/gameModel.php");


$uri = $_SERVER["REQUEST_URI"];


if ($uri == "/index.php" || $uri === "/pageAcceuil" || $uri == "/" || $uri == "/game") {
    
    // $answer = getWordFromDB($pdo);


    $title = "Page d'accueil";              //titre à afficher dans l'onglet de la page du navigateur
    $template = "Views/game.php";    //chemin vers la vue demandée
    require_once("Views/base.php");         //appel de la page de base qui sera remplie avec la vue demandée
}