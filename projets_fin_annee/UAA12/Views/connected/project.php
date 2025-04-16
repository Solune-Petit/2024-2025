<div class="flexible space-around" style="width: 100%; margin: 10px;">
    <div class="projectLeft flex-column space-between align-item-center">
        <div class="flexible">
            <?php foreach ($_SESSION["categories"] as $cat): ?>

                <div class="cat flex-column align-item-center">

                    <form class="flexible" action="" method="post">
                        <button type="submit" class="arrows" name="moveBack" id="moveBack"><- </button>
                                <h1><?= $cat->categorieNom ?></h1>
                                <button type="submit" class="arrows" name="moveUp" id="moveUp">-></button>
                    </form>
                </div>

            <?php endforeach ?>
        </div>

        <div class="flexible">
            <button onclick="changeDiv()">ajouter une catégorie</button>
            <div class="div1 profileDiv"></div>
            <div class="div2" style="display: none; margin:30px;">
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
</script>