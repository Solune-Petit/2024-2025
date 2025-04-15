<?php

function createProject($pdo){

    try{
        $query = "INSERT INTO `solune`.`projet` (`ProjetTitle`, `ProjetDescription`, `projetMaker`) VALUES (:ProjetTitle, :ProjetDescription, :projetMaker)";
        $createProjet = $pdo->prepare($query);
        $createProjet->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->UserID
        ]);

        $query = "SELECT * FROM `solune`.`projet` where ProjetTitle = :ProjetTitle and ProjetDescription = :ProjetDescription and projetMaker = :projetMaker";
        $fetchProject = $pdo->prepare($query);
        $fetchProject->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->UserID
        ]);
        $projet = $fetchProject->fetch();
        $_SESSION["project"] = $projet;

    }catch(PDOException $e){
        $message = $e->getMessage();
        die($message);
    }

}

