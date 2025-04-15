<?php

require_once("Models/projectModels.php");

$uri = $_SERVER["REQUEST_URI"];

if(isset($_POST["projectSubmit"])){
    createProject($pdo);
    header("location:/project");
}else if(isset($_GET["ProjetID"]) && $uri === "/project?ProjetID=".$_GET["ProjetID"]){
    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}

?>