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
        header("location:#");
    }
    
    
    $title = "Projet";
    $template = "Views/connected/project.php";
    require_once("Views/base.php");
}
else if(str_contains($uri,"cardID")){
    deleteCard($pdo, $_GET["cardID"]);
    header("location:/project?ProjetID=".$_SESSION["project"]->projetID);
}
else if(str_contains($uri,"catID"))
{
    
    deleteCat($pdo, $_GET["catID"]);
    header("location:/project?ProjetID=".$_SESSION["project"]->projetID);
    var_dump("coucou");
}
else if (isset($_SESSION["project"]) && $uri === "/projectSettings?ProjetID=" . $_SESSION["project"]->projetID){
    
    fetchAllUserOfProject($pdo, $_GET["ProjetID"]);

    if(isset($_POST["AddUserProject"])){
        AddUserProject($pdo, $_POST["Email"], $_GET["ProjetID"]);
        header("location:#");
    }

    $title = "options du projet";
    $template = "Views/connected/projectSettings.php";
    require_once("Views/base.php");
}else if (str_contains($uri,"UserToDel")){

    var_dump("coucou");
    delUserProject($pdo, $_GET["UserToDel"], $_GET["ProjectID"]);
    header("location:/projectSettings?ProjetID=" . $_SESSION["project"]->projetID);
}
?>