<div class="profile">
    <div id="container">
        <div class="div1 profileDiv">
            <h1>Voici votre profile</h1>
            <p>Nom : <?= $_SESSION["user"]->UserNom ?></p>
            <p>Prenom : <?= $_SESSION["user"]->UserPrenom ?></p>
            <p>Adress Email : <?= $_SESSION["user"]->UserMail?></p>
            <p>Nom d'utillisateur : <?= $_SESSION["user"]->UserLogin?></p>
            <p>Mot de passe : <?php for($i=0;$i<strlen($_SESSION["user"]->UserPassword);$i++){
                echo("*");
            } ?></p>
        </div>
        <div class="div2 profileDiv" style="display: none;">Div 2</div>
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