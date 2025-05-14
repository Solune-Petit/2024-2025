<?php

    session_start();

    require_once("./Configs\connectToDB.php");
    require_once("./Controllers/indexController.php");
    require_once("./Controllers/userController.php");
    require_once("./Controllers/projectController.php");
?>

<?=var_dump($_SESSION["user"])?>
