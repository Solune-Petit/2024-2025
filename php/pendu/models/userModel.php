<?php

/*
Fonction createUser
BUT: ajouter les données encodées par l'utilisateur dans la table des utilisateurs
IN: $pdo reprenant toutes les informations de connexion
*/
// require_once 'vendor/autoload.php';

function createUser($pdo)
{
    try {
    //définition de la requête d'insertion en utilisant la notion de paramètre
    $query = 'insert into utilisateurs (nomUser, prenomUser, loginUser, passWordUser, emailUser, role, adresseUser, villeUser, CPUser)
    values (:nomUser, :prenomUser, :loginUser, :passWordUser, :emailUser, :role, :adresseUser, :villeUser, :CPUser)';
    //préparation de la requête
    $ajouteUser = $pdo->prepare($query);
    //exécution en attribuant les valeurs récupérées dans le formulaire aux paramètres
    $ajouteUser->execute([
        'nomUser' => $_POST["nom"],
        'prenomUser' => $_POST["prenom"],
        'loginUser' => $_POST["login"],
        'passWordUser' => $_POST["mot_de_passe"],
        'emailUser' => $_POST["email"],
        'role' => 'user',
        'adresseUser' => $_POST["adresse"],
        'villeUser' => $_POST["ville"],
        'CPUser' => $_POST["CP"]
    ]);
    }catch (PDOEXCEPTION $e) {
        $message = $e->getMessage();
        die($message); }
}


/*
Fonction connectUser
BUT: rechercher les données de l'utilisateurs dans la base de données pour les mémoriser dans la variable session
IN: $pdo reprenant toutes les informations de connexion
*/
function connectUser($pdo)
{
    try {
    //définition de la requête select en utilisant la notion de paramètre
    $query = 'select * from utilisateurs where loginUser = :loginUser and passWordUser = :passWordUser';
    //préparation de la requête
    $connectUser = $pdo->prepare($query);
    //exécution en attribuant les valeurs récupérées dans le formulaire aux paramètres
    $connectUser->execute([
    'loginUser' => $_POST["login"],
    'passWordUser' => $_POST["mot_de_passe"]
    ]);
    //stokage des données trouvées dans la variable $user
    $user = $connectUser->fetch();
    if (!$user) {
    return false;
    }
    else{
    //ajout de celle-ci à la variable session
    $_SESSION["user"] = $user;
    return true;
    }
    } catch (PDOException $e) {
    $message = $e->getMessage();
    die($message);
    }
}

function updateUser($pdo)
{
    try 
    {
        $query = 'update utilisateurs set nomUser = :nomUser, prenomUser = :prenomUser, passWordUser = :passWordUser, emailUser = :emailUser where id = :id';
        $ajouteUser = $pdo->prepare($query);
        $ajouteUser->execute([
            'nomUser' => $_POST["nom"],
            'prenomUser' => $_POST["prenom"],
            'passWordUser' => $_POST["mot_de_passe"],
            'emailUser' => $_POST["email"],
            'id' => $_SESSION["user"]->id
        ]);
    } catch (PDOException $e)
    {
        $message = $e->getMessage();
        die($message);
    }
}

function updateSession($pdo)
{
    try
    {
        $query = 'select * from utilisateurs where id = :id';
        $selectUser = $pdo->prepare($query);
        $selectUser->execute([
            'id' => $_SESSION["user"]->id
        ]);
        $user = $selectUser->fetch();
        $_SESSION["user"] = $user;
    } catch (PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}

function deleteProfile($pdo)
{
    try {
        $query = 'delete from utilisateurs where id = :id';
        $delUser = $pdo->prepare($query);
        $delUser->execute([
            'id' =>$_SESSION["user"]->id
        ]);
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}