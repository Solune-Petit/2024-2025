<!-- regarder imgs dans notes -->

<a href="acceuil">Acceuil</a>

<?php if (!empty($_SESSION["project"])):?>
    <a href="projectSettings?ProjetID=<?= $_SESSION["project"]->projetID ?>">Options du projet</a>
<?php endif?>

<?php if(!isset($_SESSION["user"])): ?>

    <a href="LogIn-Off">Se conecter</a>

<?php else: ?>
    <a href="Profile">Profile</a>
    <a href="disconnect">Se déconnecter</a>
<?php endif ?>