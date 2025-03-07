<?php

$uri = $_SERVER["REQUEST_URI"];

if (($uri === '/' || $uri === '/acceuilDemo' || $uri === '/index.php') && !isset($_SESSION["user"])){

    $title = "Chrono Work Acceuil";
    $template = "Views/acceuilDemo.php";
    require_once("Views/base.php");
}