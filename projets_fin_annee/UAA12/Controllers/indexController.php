<?php

$uri = $_SERVER["REQUEST_URI"];

if (($uri === '/' || $uri === '/acceuil' || $uri === '/index.php') && !isset($_SESSION["user"])){

    $title = "acceuil";
    $template = "Views/acceuilDemo.php";
    require_once("Views/base.php");
}