<?php

function createUser($pdo){
    try
    {
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

    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}

function connectUser($pdo){
    try{
        $query = "SELECT * FROM user where UserLogin = :loginUsername and UserPassword = :loginPassword";
        $connection = $pdo->prepare($query);
        $connection->execute([
            'loginUsername' => $_POST['loginUsername'],
            'loginPassword' => $_POST['loginPassword'],
        ]);
        $user = $connection->fetch();
        if(!$user){
            return false;
        }else{
            $_SESSION["user"] = $user;
            return true;
        }
    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}


function logOutUser($pdo){
    session_destroy();
    header("Location:/");
}

function fetchUserProject($pdo){
    try{
        $query = "Select * from Projet where ProjetID IN (SELECT ProjetID FROM userprojet WHERE UserID = :userID)";
        $fetch = $pdo->prepare($query);
        $fetch->execute(['userID' => $_SESSION['user']->UserID]);
        $projet = $fetch->fetchAll();
        $_SESSION["userProject"] = $projet;

    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}