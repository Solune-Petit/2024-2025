<?php

function getAllUsersInfos($pdo){
    try {
        $query = "SELECT * from utilisateurs";
        $selectAllUser = $pdo->prepare($query);
        $selectAllUser->execute([]);
        $Users = $selectAllUser->fetchAll();
        return $Users;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function getAllStoresInfos($pdo){
    try {
        $query = "SELECT * from stores";
        $selectAllStores = $pdo->prepare($query);
        $selectAllStores->execute([]);
        $stores = $selectAllStores->fetchAll();
        return $stores;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

?>