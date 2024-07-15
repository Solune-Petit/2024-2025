<?php
// En cas d'erreur, on affiche le message de l'erreur attrapée

try {
    $strConnexion = "mysql:host=localhost;dbname=bddsiteuaa12-2024.2025";
    $pdo = new PDO($strConnexion, "root", "root", [
        PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
        PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_OBJ
    ]);
} catch (PDOException $e)
{
    $message = $e->getMessage();
    die($message);
}