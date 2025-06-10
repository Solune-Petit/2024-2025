<?php
//pour se connecter à la BDD de la salle de classe, il faut commenter les lignes 6 et 9 et décommenter les lignes 7 et 8

try {
    //bdd perso
    $strConnexion = "mysql:host=localhost;port=3306;dbname=solune";
    // $strConnexion = "mysql:host=10.10.51.98:3306;dbname=solune";
    // $pdo = new PDO($strConnexion, "solune", "root", [
    $pdo = new PDO($strConnexion, "root", "root", [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_OBJ
    ]);
} catch (PDOException $e)
{
    $message = $e->getMessage();
    die($message);
}