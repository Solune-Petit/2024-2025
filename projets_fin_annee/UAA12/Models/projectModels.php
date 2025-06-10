<?php

function createProject($pdo)
{

    try {
        $query = "INSERT INTO `solune`.`projet` (`projetTitle`, `projetDescription`, `projetMaker`) VALUES (:ProjetTitle, :ProjetDescription, :projetMaker)";
        $createProjet = $pdo->prepare($query);
        $createProjet->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->userID
        ]);


        $query = "SELECT * FROM `solune`.`projet` where projetTitle = :ProjetTitle and projetDescription = :ProjetDescription and projetMaker = :projetMaker";
        $fetchProject = $pdo->prepare($query);
        $fetchProject->execute([
            'ProjetTitle' => $_POST['projectTitle'],
            'ProjetDescription' => $_POST['projectDescription'],
            'projetMaker' => $_SESSION["user"]->userID
        ]);
        $projet = $fetchProject->fetch();
        $_SESSION["project"] = $projet;


        $query = "INSERT INTO solune.userprojet (userID, projetID) VALUES (:UserID, :ProjetID)";
        $joinUserProjet = $pdo->prepare($query);
        $joinUserProjet->execute([
            'UserID' => $_SESSION["user"]->userID,
            'ProjetID' => $_SESSION["project"]->projetID,
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function fetchProject($pdo, $projectID)
{
    try {

        $query = "SELECT * FROM projet WHERE projetID = $projectID";
        $fetchProject = $pdo->prepare($query);
        $fetchProject->execute();
        $projet = $fetchProject->fetch();
        $_SESSION["project"] = $projet;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function createCat($pdo)
{
    try {
        $query = "INSERT INTO categorie (categorieNom, categoriePosition, projetID) VALUES (:categorieNom, :categoriePosition, :projetID)";
        $addCat = $pdo->prepare($query);
        $addCat->execute([
            'categorieNom' => $_POST["catName"],
            'categoriePosition' => "1",
            'projetID' => $_SESSION["project"]->projetID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function fetchCat($pdo)
{
    try {
        $query = "SELECT * FROM categorie WHERE projetID = :projetID ORDER BY categoriePosition";
        $fetchCat = $pdo->prepare($query);
        $fetchCat->execute([
            'projetID' => $_SESSION["project"]->projetID
        ]);

        $categories = $fetchCat->fetchAll();
        $_SESSION["categories"] = $categories;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function deleteCat($pdo, $catID)
{

    try {
        $query = "";
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }

    try {
        $query = "DELETE FROM categorie WHERE categorieID = :categorieID";
        $deleteCat = $pdo->prepare($query);
        $deleteCat->execute([
            ":categorieID" => $catID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function switchCatPos($pdo)
{

    try {
        $query = "SELECT categorieID, categoriePosition from categorie where (categoriePosition = :echange and projetID = :projetID)";
        $switchCat = $pdo->prepare($query);
        $switchCat->execute([
            "echange" => $_POST["place"],
            "projetID" => $_SESSION["project"]->projetID,
        ]);

        $temp = $switchCat->fetch();

        $query = "UPDATE categorie SET categoriePosition = :echangeur WHERE categorieID = :categorieID;";
        $switchCat = $pdo->prepare($query);
        $switchCat->execute([
            "echangeur" => $_POST["place"],
            "categorieID" => $_POST["categorieID"]
        ]);

        if ($temp != null) {

            $query = "UPDATE categorie SET categoriePosition = :echange where categorieID = :categorieID ";
            $switchCat = $pdo->prepare($query);
            $switchCat->execute([
                "echange" => $_POST["categoriePosition"],
                "categorieID" => $temp->categorieID
            ]);
        }


        fetchCat($pdo);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function fetchCard($pdo)
{
    try {
        $query = "SELECT * from carte";
        $fetchAllCards = $pdo->prepare($query);
        $fetchAllCards->execute([]);
        $_SESSION["AllCards"] = $fetchAllCards->fetchAll();
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function addCard($pdo)
{
    try {
        $query = "INSERT INTO carte (carteNom, carteDescription, categorieID) VALUES (:carteNom, :carteDescription, :categorieID)";
        $addcard = $pdo->prepare($query);
        $addcard->execute([
            "carteNom" => $_POST["cardName"],
            "carteDescription" => $_POST["cardDescription"],
            "categorieID" => $_POST["categorieID"],
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function switchCard($pdo)
{
    try {
        $query = "UPDATE carte SET categorieID = :newPos WHERE carteID = :cardID";
        $switchcard = $pdo->prepare($query);
        $switchcard->execute([
            "newPos" => $_POST["categorie"],
            "cardID" => $_POST["cardID"]
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function deleteCard($pdo, $cardID)
{

    try {
        $query = "DELETE FROM carte WHERE carteID = :cardID";
        $deletecard = $pdo->prepare($query);
        $deletecard->execute([
            "cardID" => $cardID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function fetchAllUserOfProject($pdo, $projectID)
{
    try {
        $query = "SELECT * FROM solune.userprojet WHERE projetID = :projetID";
        $fetchAll = $pdo->prepare($query);
        $fetchAll->execute([
            "projetID" => $projectID
        ]);
        $userProjects = $fetchAll->fetchAll();
        $_SESSION["usersOfProject"] = $userProjects;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function fetchUserInfo($pdo, $userID)
{
    try {
        $query = "SELECT * FROM user WHERE userID = :userID";
        $userInfo = $pdo->prepare($query);
        $userInfo->execute([
            "userID" => $userID
        ]);
        $user = $userInfo->fetch();
        $_SESSION["tempUserInfo"] = $user;
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function delUserProject($pdo, $userID, $projectID)
{
    try {
        $query = "DELETE FROM userprojet WHERE userID = :userID and projetID = :projetID;";
        $delete = $pdo->prepare($query);
        $delete->execute([
            "userID" => $userID,
            "projetID" => $projectID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}

function AddUserProject($pdo, $mail, $projectID)
{

    try{
        $query = "SELECT userID FROM user where userMail = :userMail";
        $fetchUserID = $pdo->prepare($query);
        $fetchUserID->execute([
            "userMail"=> $mail,
        ]);
        $user = $fetchUserID->fetch();
    }catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }

    try {
        $query = "INSERT INTO userprojet (userID, projetID) VALUES (:userID, :projetID)";
        $insert = $pdo->prepare($query);
        $insert->execute([
            "userID" => $user->userID,
            "projetID" => $projectID
        ]);
    } catch (PDOException $e) {
        $message = $e->getMessage();
        die($message);
    }
}
