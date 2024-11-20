<?php

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/inscriptionOrEditProfil") {

    if (isset($_POST['btnEnvoi']))
    {
        createUser($pdo);
        header('location:/');

        connectUser($pdo);
    }

    $title = "inscription chocolaterie astronautic";
    $template = "Views/Users/inscriptionOrEditProfil.php";
    require_once("Views/base.php");

    
} else if ($uri == "/connexion") {
    // if (isset($_POST['btnEnvoi'])) {
    //     try {
    //         //définition de la requête select en utilisant la notion de paramètre
    //         $query = 'select * from utilisateurs where loginUser = :loginUser';
    //         //préparation de la requête
    //         $connectUser = $pdo->prepare($query);
    //         //exécution en attribuant les valeurs récupérées dans le formulaire aux paramètres
    //         $connectUser->execute([
    //             'loginUser' => $_POST["login"],
    //         ]);
    //     } catch (PDOException $e) {
    //         $message = $e->getMessage();
    //         die($message);
    //     }
    // }
    
    if (isset($_POST['btnEnvoi'])) {
        //ajout de l'utilisateur à la base de données
        if (connectUser($pdo)) {
            header('location:/index.php');
        }
    }

    $title = "connexion";
    $template = "Views/Users/connexion.php";
    require_once("Views/base.php");


} else if ($uri == "/deconnexion") {

    session_destroy();
    header("location:/");


} else if ($uri == "/updateProfile"){
    $title = "modifier profil";
    $template = "Views/Users/inscriptionOrEditProfil.php";
    require_once("Views/base.php");


} else if ($uri == "/deleteProfile"){
    
    deleteProfile($pdo);
    header("location:/");


}else if ($uri == "/orders"){
    $title = "Vos commandes";
    $template = "Views/Users/orders.php";
    require_once("Views/base.php");
}