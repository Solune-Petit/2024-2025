<div class="flexible main space-around">
    <div style="width: 80%;">
        <h1>Personnes participant au projet</h1>
        <div class=" settingsRight flexible align-item-center space-around">
            <?php foreach ($_SESSION["usersOfProject"] as $user) : ?>
                <div class="userSettings flex-column align-item-center space-around">
                    <?php fetchUserInfo($pdo, $user->userID); ?>
                    <p><?=$_SESSION["tempUserInfo"]->userNom ?> <?=$_SESSION["tempUserInfo"]->userPrenom ?></p>
                    <p><?=$_SESSION["tempUserInfo"]->userMail ?></p>
                    <a href="delUserProject?ProjectID=<?=$_GET["ProjetID"]?>&UserToDel=<?=$_SESSION["tempUserInfo"]->userID?>">Suprimer l'utilisateur</a>
                </div>
            <?php endforeach ?>
        </div>
    </div>
    <div class="settingsLeft flex-column align-item-center justify-content-center">
        <h1>Ajouter un utillisateur</h1>
        <form action="" method="post">
            <legend>Email de l'utillisateur à rajouter</legend>
            <input type="text" name="Email" id="Email">
            <input type="submit" name="AddUserProject" id="AddUserProject">
        </form>
    </div>
</div>