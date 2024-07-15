<?php

require_once("models/userModel.php");

$url = $_SERVER["REQUEST_URI"];

if ($url == "/identify") {

    // espace pour mettre la fonction de connexion

    $title = "SignIN / SignUP";
    $template = "views/user/sign.php";
    require_once("views/base.php");
}
