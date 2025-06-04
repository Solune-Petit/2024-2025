<?php

require_once("Models/projectModels.php");


$uri = $_SERVER["REQUEST_URI"];

if(isset($_POST["projectSubmit"])){
    createProject($pdo);
    header("location:/project?ProjetID=".$_SESSION["project"]->ProjetID);
}else if(isset($_GET["ProjetID"]) && $uri === "/project?ProjetID=".$_GET["ProjetID"]){
    
    $categorieID;

    fetchProject($pdo, $_GET["ProjetID"]);
    fetchCat($pdo);
    fetchCard($pdo);
    
    if(isset($_POST["addCatBtn"])){
        createCat($pdo);
        header("location:#");
    }else if (isset($_POST["changePlace"])){
        switchCatPos($pdo);
        // header("location:#");
    }else if (isset($_POST["cardName"])){
        addCard($pdo);
        header("location:#");
    }else if (isset($_POST["switchCard"])){
        switchCard($pdo);
    }
    
    
    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}
else if(str_contains($uri,"catID"))
{
    var_dump("coucou");
    
    
    deleteCat($pdo, $_GET["catID"]);
    header("location:/project?ProjetID=".$_SESSION["project"]->projetID);
    var_dump("coucou");
}
else if (isset($_SESSION["project"]) && $uri === "/project/projectSettings?ProjetID=" . $_SESSION["project"]->projetID){
    
    $title = "paramètre de \"" . $_SESSION["project"]->projetTitle . "\"";
    $template = "Views/connected/projectSettings.php";
    require_once("Views/base.php");
}
?>