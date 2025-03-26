<div class="rightPart">
<h1>Bienvenue <?php echo (strtoupper($_SESSION["user"]->UserLogin)) ?></h1>
<p>voici vos projets :</p>
<div class="projects">
    <?php foreach ($_SESSION["userProject"] as $project) : ?>
        <a href="project.php?projectID=<?= $project->ProjetID ?>">
            <div class="project">
                <h2><?= $project->ProjetTitle ?></h2>
                <h3><?= $project->projetMaker ?></h3>

            </div>
        </a>
    <?php endforeach; ?>
</div>