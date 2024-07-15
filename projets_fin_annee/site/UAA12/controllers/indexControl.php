<?php

$url = $_SERVER["REQUEST_URI"];

///////////////////////////////////////////////////////////////////////////////////////

if ($url == "/index.php" || $url == "/" || $url == "/home"){

    $title = "page d'acceuil";
    $template = "views/home.php";
    require_once("views/base.php");
}