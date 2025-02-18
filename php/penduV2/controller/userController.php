<?php

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/LogIn") {
    if (isset($_POST['loginBtn'])) {
        //ajout de l'utilisateur à la base de données
        if (connectUser($pdo)) {
            header('location:/game');
        }
    }else if (isset($_POST['registerBtn'])) {
        if (createUser($pdo)) {
            connectUser($pdo);
            header('location:/game');
        }
    }

    $title = "connexion";
    $template = "Views/Users/Connexion.php";
    require_once("Views/base.php");


} else if ($uri == "/LogOf") {

    disconnectUser();
    header("location:/game");
}