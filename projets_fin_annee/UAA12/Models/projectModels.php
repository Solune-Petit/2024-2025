<?php

function createProject($pdo){

    try{
        $query = "INSERT INTO `solune`.`projet` (`ProjetTitle`, `ProjetDescription`, `projetMaker`) VALUES (:ProjetTitle, :ProjetDescription, :projetMaker)";
        $createProjet = $pdo->prepare($query);
        $createProjet->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->userID
        ]);

        
        $query = "SELECT * FROM `solune`.`projet` where ProjetTitle = :ProjetTitle and ProjetDescription = :ProjetDescription and projetMaker = :projetMaker";
        $fetchProject = $pdo->prepare($query);
        $fetchProject->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->userID
        ]);
        $projet = $fetchProject->fetch();
        $_SESSION["project"] = $projet;


        $query = "INSERT INTO solune.userprojet (UserID, ProjetID) VALUES (:UserID, :ProjetID)";
        $joinUserProjet = $pdo->prepare($query);
        $joinUserProjet->execute([
            'UserID'=>$_SESSION["user"]->userID,
            'ProjetID'=>$_SESSION["project"]->projetID,
        ]);

    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }

}

function createCat($pdo){
    try{
        $query = "INSERT INTO categorie (categorieNom, categoriePosition, projetID) VALUES (:categorieNom, :categoriePosition, :projetID)";
        $addCat = $pdo->prepare($query);
        $addCat->execute([
            'categorieNom' =>$_POST["catName"],
            'categoriePosition'=>"1",
            'projetID'=>$_SESSION["project"]->projetID
        ]);

    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}

function fetchCat($pdo){
    try{
        $query = "SELECT * FROM categorie WHERE projetID = :projetID ORDER BY projetID";
        $fetchCat = $pdo->prepare($query);
        $fetchCat->execute([
            'projetID' => $_SESSION["project"]->projetID
        ]);

        $categories = $fetchCat->fetchAll();
        $_SESSION["categories"] = $categories;
    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }
}