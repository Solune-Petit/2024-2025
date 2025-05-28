<?php
// En cas d'erreur, on affiche le message de l'erreur attrapée

try {
    //bdd perso
    // $strConnexion = "localhost:3306;dbname=solune";
    $strConnexion = "mysql:host=10.10.51.98:3306;dbname=solune";
    $pdo = new PDO($strConnexion, "solune", "root", [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_OBJ
    ]);
} catch (PDOException $e)
{
    $message = $e->getMessage();
    die($message);
}