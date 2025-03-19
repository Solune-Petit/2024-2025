<!-- regarder imgs dans notes -->

<a href="acceuil">acceuil</a>

<?php if(!isset($_SESSION["user"])): ?>

    <a href="LogIn-Off">connect</a>

<?php else: ?>
    <a href="Profile">Profile</a><a href="disconnect">Se déconnecter</a>
<?php endif ?>