<?php

require_once("Models/userModels.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri === '/LogIn-Off' ){


    if (isset($_POST["loginBtn"])){
        if(connectUser($pdo)){
            header("Location: /acceuil");
            fetchUserProject($pdo);

        }else{
            echo "Erreur lors de la connexion de l'utilisateur";
        }
    }else if(isset($_POST["registerBtn"])){
        if(createUser($pdo)){
            header("Location:/");
        }
    }
    $title = "Log In";
    $template = "Views\Users\connect.php";
    require_once("Views/base.php");
}else if ($uri === '/disconnect'){
    logOutUser($pdo);
    header('Location: /');
}else if ($uri === '/Profile'){

    if(isset($_POST["updateProfile"])){
        updateProfile($pdo);
    }


    $title = "Profile";
    $template = "Views\Users\profile.php";
    require_once("Views/base.php");
}