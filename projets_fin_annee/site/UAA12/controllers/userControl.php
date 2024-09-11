<?php

require_once("models/userModel.php");

$url = $_SERVER["REQUEST_URI"];

if ($url == "/identify") {

    if (isset($_POST['registerBTN'])) {
        createUser($pdo);
        header('location:/');
    }

    if (isset($_POST["connectBTN"])) {
        if (connectUser($pdo)) {
            header("location:/");
        }
    }

    // espace pour mettre la fonction de connexion

    $title = "SignIN / SignUP";
    $template = "views/user/sign.php";
    require_once("views/base.php");
} else if ($url == "/profile") {
    $title = "Votre profile";
    $template = "views/user/profile.php";
    require_once("views/base.php");
}else if ($url == "/disconnect"){
    session_destroy();
    header("location:/");
}