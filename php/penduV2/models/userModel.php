<?php

function createUser($pdo){
    
    //creating user in database
    try{
        $query = "INSERT INTO `user` (`userName`, `userPassword`, `userEmail`, `userStatus`) VALUES (:userName, :userPassword, :userEmail, :userStatus)";
        $addUser = $pdo->prepare($query);
        $addUser->execute([
            'userName' => $_POST['registerUsername'],
            'userPassword' => $_POST['registerPassword'],
            'userEmail' => $_POST['registerEmail'],
            'userStatus' => 'user'
        ]);
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message); 
    }

    //auto connect user to database
    try{
        $query = "SELECT * FROM `user` WHERE `userName` = :userName AND `userPassword` = :userPassword";
        $getUser = $pdo->prepare($query);
        $getUser->execute([
            'userName' => $_POST['registerUsername'],
            'userPassword' => $_POST['registerPassword']
        ]);
        $user = $getUser->fetch();
        if(!$user){
            return false;
        }else{
            $_SESSION['user'] = $user;
            return true;
        }
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message); 
    }
}


function connectUser($pdo){
    try{
        $query = "SELECT * FROM `user` WHERE `userName` = :userName AND `userPassword` = :userPassword";
        $getUser = $pdo->prepare($query);
        $getUser->execute([
            'userName' => $_POST['loginUsername'],
            'userPassword' => $_POST['loginPassword']
        ]);
        $user = $getUser->fetch();
        if(!$user){
            return false;
        }else{
            $_SESSION['user'] = $user;
            return true;
        }
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message); 
    }
}

function disconnectUser(){
    session_destroy();
}

function deleteUser($pdo){

    try{

        $query = "DELETE FROM `user` WHERE `id` = :id";
        $deleteUser = $pdo->prepare($query);
        $deleteUser->execute([
            'id' => $_SESSION['user']->id
        ]);
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message); 
    }

}