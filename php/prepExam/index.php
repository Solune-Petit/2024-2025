<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Prépartion examin UAA12 Petit Solune</title>
</head>
<body>
    <header>
        <button><a href="home">Home</a></button><button><a href="triangle">Testez l'aplication</a></button><button><a href=""></a></button>
    </header>
    <main>
        <div class="title"><h1>Commandez notre application AstyCalc</h1></div>
        <!-- gros bloc du millieu -->
         <div class="flexible space-around">
            <div class="bloc">
                <p>galerie images</p>
                <?php
                    for ($i = 0; $i <16; $i++) :
                        for ($j = 0; $j < 4; $j++) :?>
                        <img src="img/img<?php echo $i+1?>.png" alt="image<?php echo $i+1?>">
                <?php endfor; endfor?>
            </div>
            <div></div>
            <div></div>
         </div>
    </main>
</body>
</html>