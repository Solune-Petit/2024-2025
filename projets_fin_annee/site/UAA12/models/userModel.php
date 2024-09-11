<?php

function createUser($pdo)
{
    try {
        $query = 'INSERT into user (userLogin, userMail, userPassword)
        values (:userLogin, :userMail, :userPassword)';
        $addUser = $pdo->prepare($query);
        $addUser->execute([
            'userLogin' => $_POST["login"],
            'userMail' => $_POST["email"],
            'userPassword' => $_POST["password"]
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function connectUser($pdo)
{
    try {
        $query = 'SELECT * from user where userMail = :email and userPassword = :password';
        $connectUser = $pdo->prepare($query);
        $connectUser->execute([
            'email' => $_POST["email"],
            'password' => $_POST["password"]
        ]);
        $user = $connectUser->fetch();
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
