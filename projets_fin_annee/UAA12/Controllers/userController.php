<?php

require_once("../Models/userModels.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri === '/LogIn-Off' ){

    $title = "Log In";
    $template = "Views\Users\connect.php";
    require_once("Views/base.php");
}