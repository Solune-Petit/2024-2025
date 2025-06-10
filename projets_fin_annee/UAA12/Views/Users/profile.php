<div class="profile">
    <div id="container">
        <div class="div1 profileDiv">
            <h1>Voici votre profile</h1>
            <p>Nom : <?= $_SESSION["user"]->userNom ?></p>
            <p>Prenom : <?= $_SESSION["user"]->userPrenom ?></p>
            <p>Adress Email : <?= $_SESSION["user"]->userMail ?></p>
            <p>Nom d'utillisateur : <?= $_SESSION["user"]->userLogin ?></p>
            <p>Mot de passe : <?php for ($i = 0; $i < strlen($_SESSION["user"]->userPassword); $i++) {
                                    echo ("*");
                                } ?></p>
        </div>
        <div class="div2 profileDiv" style="display: none;">
            <form action="" method="post">
                <div class="input-group">
                    <label for="registerName">name</label>
                    <input type="text" id="registerName" name="registerName" required value="<?= $_SESSION["user"]->userNom ?>">
                </div>
                <div class="input-group">
                    <label for="registerSurname">Surname</label>
                    <input type="text" id="registerSurname" name="registerSurname" required value="<?= $_SESSION["user"]->userPrenom ?>">
                </div>
                <div class="input-group">
                    <label for="registerEmail">Email</label>
                    <input type="email" id="registerEmail" name="registerEmail" required value="<?= $_SESSION["user"]->userMail ?>">
                </div>
                <div class="input-group">
                    <label for="registerLogin">login</label>
                    <input type="text" id="registerLogin" name="registerLogin" required value="<?= $_SESSION["user"]->userLogin ?>">
                </div>
                <div class="input-group">
                    <label for="registerPassword">Password</label>
                    <input type="password" id="registerPassword" name="registerPassword" required value="<?= $_SESSION["user"]->userPassword ?>">
                </div>
                <button type="submit" name="updateProfile" class="btn">changer votre profile</button>
            </form>
        </div>
    </div>

    <button onclick="changeDiv()">Changer votre profile</button>

</div>

<script>
    let currentDiv = 1;

    function changeDiv() {
        const container = document.getElementById("container");
        const div1 = document.querySelector(".div1");
        const div2 = document.querySelector(".div2");

        if (currentDiv === 1) {
            div1.style.display = "none";
            div2.style.display = "block";
            currentDiv = 2;
        } else {
            div2.style.display = "none";
            div1.style.display = "block";
            currentDiv = 1;
        }
    }

    // Vérification de l'état initial des divs au chargement de la page
    window.onload = function() {
        if (document.querySelector(".div2").style.display === "block") {
            currentDiv = 2;
        }
    };
</script>