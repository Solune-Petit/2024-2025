<?php
$count = 0;
?>

<div class="flex-column align-item-center" style="width: 100%; margin: 10px;">
    <h1>Nom du projet : <?= $_SESSION["project"]->projetTitle ?></h1>
    <div class="flexible space-around" style="width: 100%; margin: 10px;">
        <div class="projectLeft flex-column space-between align-item-center scrollable">
            <div class="flexible space-between ">
                <?php foreach ($_SESSION["categories"] as $cat):
                    $count++; ?>

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
                                        <input type="number" name="place" id="place" placeholder="<?= $cat->categoriePosition ?>" style="width: 35px;" required>
                                        <input type="submit" name="changePlace" id="changePlace">
                                        <input class="hidden" type="numbre" name="categoriePosition" id="categoriePosition" value="<?= $cat->categoriePosition ?>">
                                        <input class="hidden" type="numbre" name="categorieID" id="categorieID" value="<?= $cat->categorieID ?>">
                                    </form>
                                </div>
                            </div>
                            <div class="flex-column align-item-center">
                                <?php foreach ($_SESSION["AllCards"] as $card) :
                                    $nbrCards[$count] = 0;
                                    if ($card->categorieID === $cat->categorieID) :
                                        $nbrCards[$count]++ ?>
                                        <div class="card flex-column align-item-center">

                                            <h1><?= $card->carteNom ?></h1>
                                            <p><?= $card->carteDescription ?></p>
                                            <div class="div2_1">
                                                <button type="button" onclick="changeDiv2()">modifier</button>
                                            </div>
                                            <div class="div2_2" style="display: none">
                                                <div class="flex-column align-item-center">
                                                    <button type="button" onclick="changeDiv2()">annuler</button>

                                                    <!-- formulaire pour bouger une catégorie -->
                                                    <form action="" method="post">
                                                        <label for="place">déplacer la carte dans :</label>
                                                        <select name="categorie" id="categorie" style="width: 90px;">
                                                            <?php foreach ($_SESSION["categories"] as $cate) : ?>

                                                                <option value="<?= $cate->categorieID ?>" <?php if ($cate->categorieID == $card->categorieID) : ?> selected <?php endif ?>><?= $cate->categorieNom ?></option>

                                                            <?php endforeach ?>
                                                        </select>
                                                        <input type="submit" name="switchCard" id="switchCard">
                                                        <input class="hidden" type="numbre" name="cardID" id="cardID" value="<?= $card->carteID ?>">
                                                    </form>
                                                    <a href="/project?ProjetID=<?= $project->projetID ?>&catID=<?= $cat->categorieID ?>&cardID=<?= $card->carteID ?>">supprimer la carte</a>
                                                </div>
                                            </div>
                                        </div>
                                <?php endif;
                                endforeach ?>
                            </div>

                            <form method="post">
                                <label>ajouter une carte</label>
                                <input type="text" name="cardName" id="cardName" placeholder="nom de la carte" required>
                                <input type="text" name="cardDescription" id="cardDescription" placeholder="description de la carte" required>
                                <input class="hidden" type="numbre" name="categorieID" id="categorieID" value="<?= $cat->categorieID ?>">
                                <input type="submit" id="addCard" name="addCard">
                            </form>
                        </form>
                        <?php if ($nbrCards[$count] != 0) : ?>
                            <p style="font-size: small;">Veuillez vider les cartes avant de suprimer la catégorie</p>
                        <?php else : ?>
                            <a href="/project?ProjetID=<?= $project->projetID ?>&catID=<?= $cat->categorieID ?>">Supprimer la catégorie</a>
                        <?php endif; ?>
                    </div>



                <?php endforeach ?>

            </div>

            <div class="flexible">
                <div class="div1 profileDiv">
                    <button onclick="changeDiv()">Ajouter une catégorie</button>
                </div>
                <div class="div2" style="display: none; margin:30px;">
                    <button onclick="changeDiv()">annuler</button>
                    <form action="" method="post" class="flex-column align-item-center">
                        <label for="catName">Nom de la catégorie</label>
                        <input type="text" name="catName" id="catName" required>
                        <button type="submit" name="addCatBtn" id="addCatBtn">Valider</button>
                    </form>
                </div>
            </div>
        </div>

        <div class="projectRight">
            <h1>en construction</h1>
        </div>
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


    };

    let currentDiv3 = 1;

    function changeDiv3() {
        const div3_1 = document.querySelector(".div3_1");
        const div3_2 = document.querySelector(".div3_2");

        if (currentDiv3 === 1) {
            div3_1.style.display = "none";
            div3_2.style.display = "block";
            currentDiv3 = 2;
        } else {
            div3_2.style.display = "none";
            div3_1.style.display = "block";
            currentDiv3 = 1;
        }


    }

    // Vérification de l'état initial des divs au chargement de la page
    window.onload = function() {
        if (document.querySelector(".div2").style.display === "block") {
            currentDiv = 2;
        }
        if (document.querySelector(".div2_2").style.display === "block") {
            currentDiv2 = 2;
        }
        if (document.querySelector(".div3_2").style.display === "block") {
            currentDiv3 = 2;
        }
    };
</script>