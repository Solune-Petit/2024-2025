<?php

require_once("Models/projectModels.php");

$uri = $_SERVER["REQUEST_URI"];

if(isset($_POST["projectSubmit"])){
    createProject($pdo);
    header("location:/project?ProjetID=".$_SESSION["project"]->ProjetID);
}else if(isset($_GET["ProjetID"]) && $uri === "/project?ProjetID=".$_GET["ProjetID"]){

    fetchCat($pdo);
    
    if(isset($_POST["addCatBtn"])){
        createCat($pdo);
        header("location:#");
    }


    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}

?>