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
    
    if(isset($_POST["addCatBtn"])){
        createCat($pdo);
        header("location:#");
    }else if (isset($_POST["changePlace"])){
        switchCatPos($pdo);
        // header("location:#");
    }
    
    
    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}
else if(($uri.str_contains($uri,"catID") == true) && $uri === "/project?ProjetID=".$_GET["ProjetID"]."&catID=".$_GET["catID"])
{
    
    var_dump("coucou");
    
    deleteCat($pdo, $_GET["catID"]);
    header("location:/project?ProjetID=".$_SESSION["project"]->projetID);
}
// }else if (isset($_SESSION["project"]) && $uri === "project?ProjetID=" . $_SESSION["project"]->projetID . "?projectSettings" . $_GET["projetSettings"]){
//     var_dump("coucouu");
//     $title = "paramètre de" . $_SESSION["projet"]->projetTitle;

//     $template = "Views/connected/projectSetings.php";
//     require_once("Views/base.php");
// }
?>