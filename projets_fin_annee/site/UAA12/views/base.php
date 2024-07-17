<!DOCTYPE html>
<html lang="fr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@48,400,0,0" />
    <link rel="stylesheet" href="assets/CSS/form.css">
    <link rel="stylesheet" href="assets/CSS/flex.css">
    <link rel="stylesheet" href="assets/CSS/base.css">
    <link rel="stylesheet" href="assets/CSS/header.css">
    <link rel="stylesheet" href="assets/CSS/sign.css">
    <script src="assets/javascript/javascript.js"></script>
    <title><?= $title ?></title>
</head>

<body>

    <header>

        <?php require_once("views/components/navbar.php") ?>

    </header>

    <main>

        <?php require_once($template) ?>

    </main>

    <footer>

        <?php require_once("views/components/footer.php") ?>

    </footer>

</body>

</html>