<!-- regarder imgs dans notes -->

<a href="acceuil">acceuil</a>

<?php if (!empty($_SESSION["project"])):?>
    <a href="project?ProjetID=<?= $_SESSION["project"]->projetID ?>?projectSettings=1">options du projet</a>
<?php endif?>

<?php if(!isset($_SESSION["user"])): ?>

    <a href="LogIn-Off">connect</a>

<?php else: ?>
    <a href="Profile">Profile</a><a href="disconnect">Se déconnecter</a>
<?php endif ?>