<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../assets/CSS/navbar.css">
    <link rel="stylesheet" href="../assets/CSS/flex.css">
    <link rel="stylesheet" href="../assets/CSS/index.css">
    <title>hangman game</title>
</head>
<body>
    
    <header>
        <?php require_once("views/components/navBar.php");?>
    </header>

    <main>
        <?php require_once($template);?>
    </main>

    <footer>
        <?php require_once("views/components/footer.php");?>
    </footer>

</body>
</html>