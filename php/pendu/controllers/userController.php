<?php

require_once("Models/userModel.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == "/LogIn") {
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
    
    if (isset($_POST['loginBtn'])) {
        //ajout de l'utilisateur à la base de données
        if (connectUser($pdo)) {
            header('location:/index.php');
        }
    }else if (isset($_POST['registerBtn'])) {
        if (createUser($pdo)) {
            header('location:/');
        }
    }

    $title = "connexion";
    $template = "Views/Users/Connexion.php";
    require_once("Views/base.php");


} else if ($uri == "/deconnexion") {

    session_destroy();
    header("location:/");
}