<?php

require_once("Models\userModels.php");

if(isset($_SESSION["user"])){
    fetchUserProject($pdo);
}


$uri = $_SERVER["REQUEST_URI"];

if (($uri === '/' || $uri === '/acceuil' || $uri === '/index.php') && !isset($_SESSION["user"])){

    unset($_SESSION["project"]);

    $title = "Chrono Work Acceuil";
    $template = "Views/acceuilDemo.php";
    require_once("Views/base.php");
}else if (isset($_SESSION["user"]) && (($uri === '/' || $uri === '/acceuil' || $uri === '/index.php'))){

    unset($_SESSION["project"]);

    $title = 'acceuil';
    $template = 'Views\connected\acceuil.php';
    require_once("Views/base.php");
}