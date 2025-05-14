<?php

require_once("Models/projectModels.php");

$uri = $_SERVER["REQUEST_URI"];

if(isset($_POST["projectSubmit"])){
    createProject($pdo);
    header("location:/project?ProjetID=".$_SESSION["project"]->ProjetID);
}else if(isset($_GET["ProjetID"]) && $uri === "/project?ProjetID=".$_GET["ProjetID"]){

    fetchProject($pdo, $_GET["ProjetID"]);
    fetchCat($pdo);
    
    if(isset($_POST["addCatBtn"])){
        createCat($pdo);
        header("location:#");
    }
    else if($uri.str_contains($uri,"catID") && $uri === "/project?ProjetID=".$_GET["ProjetID"]."?catID=".$_GET["categorieID"])
    {
        // deleteCat($pdo, $_GET["categorieID"]);
        var_dump($_GET["categorieID"]);
        header("location:#");
    }


    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}else if (isset($_SESSION["project"]) && $uri === "project?ProjetID=" . $_SESSION["project"]->projetID . "/projectSettings"){
    $title = "paramètre de" . $_SESSION["projet"]->projetTitle;
    $template = "Views/connected/projectSetings.php";
    require_once("Views/base.php");
}

?>