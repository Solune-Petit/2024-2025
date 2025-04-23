<div class="flexible space-around" style="width: 100%; margin: 10px;">
    <div class="projectLeft flex-column space-between align-item-center">
        <div class="flexible space-between scrollable">
            <?php foreach ($_SESSION["categories"] as $cat): ?>

                <div class="cat">
                    <form class="flex-column align-item-center" action="" method="post">
                        <h1><?= $cat->categorieNom ?></h1>
                        <div class="div2_1">
                            <button type="button" onclick="changeDiv2()">modifier</button>
                        </div>
                        <div class="div2_2" style="display: none">
                            <div class="flex-column align-item-center">
                                <button type="button" onclick="changeDiv2()">annuler</button>
                                <form action="" method="post">
                                    <label for="place">échanger avec :</label>
                                    <input type="number" name="place" id="place" placeholder="<?= $cat->categoriePosition ?>" style="width: 35px;">
                                    <input type="submit" name="changePlace" id="changePlace">
                                </form>
                                <a href="/project?ProjetID=<?= $project->projetID ?>?catID=<?= $cat->categorieID?>">supprimer la catégorie</a>
                            </div>
                        </div>
                    </form>
                </div>

            <?php endforeach ?>

        </div>

        <div class="flexible">
            <div class="div1 profileDiv">
                <button onclick="changeDiv()">ajouter une catégorie</button>
            </div>
            <div class="div2" style="display: none; margin:30px;">
                <button onclick="changeDiv()">annuler</button>
                <form action="" method="post" class="flex-column align-item-center">
                    <label for="catName">Nom de la catégorie</label>
                    <input type="text" name="catName" id="catName" required>
                    <button type="submit" name="addCatBtn" id="addCatBtn">valider</button>
                </form>
            </div>
        </div>
    </div>

    <div class="projectRight">
        <?php if (isset($_POST["moveBack"])) {
            var_dump($cat);
        } ?>
    </div>
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



    let currentDiv2 = 1;

    function changeDiv2() {
        const div2_1 = document.querySelectorAll(".div2_1");
        const div2_2 = document.querySelectorAll(".div2_2");

        div2_1.forEach(div2_1 => {
            if (currentDiv2 === 1) {
                div2_1.style.display = "none";
            } else {
                div2_1.style.display = "block";
            }

        });

        div2_2.forEach(div2_2 => {
            if (currentDiv2 === 1) {
                div2_2.style.display = "block";
            } else {
                div2_2.style.display = "none";
            }

        });

        if (currentDiv2 == 1) {
            currentDiv2 = 2;
        } else {
            currentDiv2 = 1;
        }


    }


    // Vérification de l'état initial des divs au chargement de la page
    window.onload = function() {
        if (document.querySelector(".div2_2").style.display === "block") {
            currentDiv2 = 2;
        }
    };
</script>