<?php

require_once("Models/admin.php");

$uri = $_SERVER["REQUEST_URI"];

if ($uri == '/adminPage'){

    $users = getAllUsersInfos($pdo);
    $stores = getAllStoresInfos($pdo);

    $title = 'admin page';
    $template  = 'Views/admin/adminPage.php';   
    require_once('Views/base.php');
}

?>