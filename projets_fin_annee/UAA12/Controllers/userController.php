<?php

require_once("Models/userModels.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri === '/LogIn-Off' ){


    if (isset($_POST["loginBtn"])){
        if(connectUser($pdo)){
            header("Location: /acceuil");
        }else{
            echo "Erreur lors de la connexion de l'utilisateur";
        }
    }else if(isset($_POST["registerBtn"])){
        if(createUser($pdo)){
            header("Location : /acceuil");
        }
    }
    $title = "Log In";
    $template = "Views\Users\connect.php";
    require_once("Views/base.php");
}else if ($uri === '/disconnect'){
    logOutUser($pdo);
    header('Location: /');
}