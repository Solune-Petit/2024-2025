<div class="LogedMenu flexible space-around">
    <div class="menuLeft align-item-center flexible flex-column Background">
        <h2>Voici les projets que vous avez.</h2>
        <h2> Pour y accéder simplement cliquez sur le projet</h2>
        <div class="projects">
            <?php foreach ($_SESSION["userProject"] as $project) : ?>
                <a href="project?ProjetID=<?= $project->projetID ?>">
                    <div class="project">
                        <h2><?= $project->projetTitle ?></h2>
                    </div>
                </a>
            <?php endforeach; ?>
        </div>
    </div>
    <div class="menuRight align-item-center flexible flex-column Background">
        <h1>Créer un projet</h1>
        <form action="" method="post" class="flexible flex-column align-item-center">
            <div class="newProjectInput">
                <label for="projectTitle">Titre du projet</label>
                <input type="text" id="projectTitle" name="projectTitle" required maxlength="20">
            </div>
            <div class="newProjectInput">
                <label for="projectDescription">Description du projet</label>
                <textarea id="projectDescription" name="projectDescription" required maxlength="255"></textarea>
            </div>
            <button type="submit" class="Background" id="projectSubmit" name="projectSubmit">Créer le projet</button>
        </form>
    </div>
</div>