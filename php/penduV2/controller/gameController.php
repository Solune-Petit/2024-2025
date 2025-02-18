<?php

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/game") {

    $title = "Jeu Du Pendu";
    $template = "Views/game.php";
    require_once("Views/base.php");
}