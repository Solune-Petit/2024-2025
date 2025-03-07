<?php

require_once("Models/userModels.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri === '/LogIn-Off' ){


    if (isset($_POST["loginBtn"])){
        var_dump("coucou");
        if(connectUser($pdo)){
            header("Location: /acceuil");
        }else{
            header("Location: /LogIn-Off");
        }
    }
    $title = "Log In";
    $template = "Views\Users\connect.php";
    require_once("Views/base.php");
}