<?php

function createUser($PDO){
    try
    {
        $query = "INSERT INTO ";
    }catch(PDOException){

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