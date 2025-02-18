<?php

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/") {
    

    $title = "connexion";
    $template = "Views/game.php";
    require_once("Views/base.php");


}