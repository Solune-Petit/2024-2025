<?php 

require_once("./models/gameModel.php");


$uri = $_SERVER["REQUEST_URI"];

$letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
$WON = true;
// temp variables for testing

$guess = "HANGMAN";
$maxLetters = strlen($guess) - 1;
$responses = ["H","G","A"];


// Live variables here


// ALl the body parts
$bodyParts = ["nohead","head","body","hand","hands","leg","legs"];


// Random words for the game and you to guess
$words = [
   "HANGMAN", "BUTTERFLY" , "APPLE", "INSIDIOUSLY", "DUPLICATE",
    "CASUALTY", "GLOOMFUL"
];


if ($uri == "/index.php" || $uri === "/pageAcceuil" || $uri == "/" || $uri == "/game") {
    
    // $answer = getWordFromDB($pdo);


    $title = "Page d'accueil";              //titre à afficher dans l'onglet de la page du navigateur
    $template = "Views/game.php";    //chemin vers la vue demandée
    require_once("Views/base.php");         //appel de la page de base qui sera remplie avec la vue demandée
}