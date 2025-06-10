<?php

function createUser($pdo)
{
    try {
        $query = "INSERT INTO user(UserNom, UserPrenom, UserMail, UserPassword, UserLogin) VALUES (:UserNom, :UserPrenom, :UserMail, :UserPassword, :UserLogin)";
        $connection = $pdo->prepare($query);
        $connection->execute([
            'UserNom' => $_POST["registerName"],
            'UserPrenom' => $_POST['registerSurname'],
            'UserMail' => $_POST['registerEmail'],
            'UserPassword' => $_POST['registerPassword'],
            'UserLogin' => $_POST['registerLogin'],
        ]);

        $query = "SELECT * FROM user where UserLogin = :loginUsername and UserPassword = :loginPassword";
        $connection = $pdo->prepare($query);
        $connection->execute([
            'loginUsername' => $_POST['registerLogin'],
            'loginPassword' => $_POST['registerPassword'],
        ]);
        $user = $connection->fetch();

        $_SESSION["user"] = $user;

        return true;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function connectUser($pdo)
{
    try {
        $query = "SELECT * FROM user where userLogin = :userLogin and userPassword = :userPassword";
        $connection = $pdo->prepare($query);
        if (!isset($_SESSION["user"])) {
            $connection->execute([
                'userLogin' => $_POST['loginUsername'],
                'userPassword' => $_POST['loginPassword'],
            ]);
        } else {
            $connection->execute([
                'userLogin' => $_POST['registerLogin'],
                'userPassword' => $_POST['registerPassword'],
            ]);
        }
        $user = $connection->fetch();
        if (!$user) {
            return false;
        } else {
            $_SESSION["user"] = $user;
            return true;
        }
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}


function logOutUser($pdo)
{
    session_destroy();
    header("Location:/");
}

function fetchUserProject($pdo)
{
    try {
        // Requête SQL optimisée avec jointure
        $query = "SELECT p.*, up.*
                  FROM Projet p
                  INNER JOIN userProjet up ON p.ProjetID = up.ProjetID
                  WHERE up.UserID = :userID";

        $fetch = $pdo->prepare($query);
        $fetch->execute(['userID' => $_SESSION['user']->userID]);

        // Récupérer les résultats sous forme d'objets
        $userProjects = $fetch->fetchAll();

        // Stocker les résultats dans la session
        $_SESSION["userProject"] = $userProjects;
    } catch (PDOException $e) {
        // Gestion des erreurs plus précise
        echo "Une erreur s'est produite : " . $e->getMessage();
        // Enregistrement de l'erreur dans un fichier log (facultatif)
        error_log("Erreur fetchUserProject : " . $e->getMessage(), 3, "error.log");
    }
}

function updateProfile($pdo)
{
    try {
        $query = "UPDATE solune.user SET userNom = :userNom, userPrenom = :userPrenom, userMail = :userMail, userPassword = :userPassword, userLogin = :userLogin WHERE userID = :userID";
        $updateUser = $pdo->prepare($query);
        $updateUser->execute([
            'userNom' => $_POST["registerName"],
            'userPrenom' => $_POST["registerSurname"],
            'userMail' => $_POST["registerEmail"],
            'userPassword' => $_POST["registerPassword"],
            'userLogin' => $_POST["registerLogin"],
            'userID' => $_SESSION["user"]->userID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }

    connectUser($pdo);
}

