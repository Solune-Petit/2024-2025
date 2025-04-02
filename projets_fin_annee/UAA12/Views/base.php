<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title><?= $title ?></title>
    <script src="Assets\script\connexion.js"></script>
    <link rel="stylesheet" href="Assets\CSS\flex.css">
    <link rel="stylesheet" href="Assets\CSS\header.css">
    <link rel="stylesheet" href="Assets\CSS\base.css">
    <link rel="stylesheet" href="Assets\CSS\connexion.css">
    <link rel="stylesheet" href="Assets\CSS\acceuilDemo.css">
    <link rel="stylesheet" href="Assets\CSS\projectNav.css">
</head>
<body>
    <header class="flexible space-between align-item-center">
        <?php require_once("Views/components/header.php") ?>
    </header>
    <main class="flexible">
        <div class="rightPart">
        <?php 
            require_once("Views\components\projectNav.php");
        ?>
        </div>
        <?=
            require_once($template) ?>
    </main>
    <footer>
        <?php require_once("Views/components/footer.php") ?>
    </footer>
</body>
</html>