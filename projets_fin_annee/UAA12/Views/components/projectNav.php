<h1>Bienvenue <?php echo (strtoupper($_SESSION["user"]->userLogin)) ?></h1>
<p>voici vos projets :</p>
<div class="projects">
    <?php foreach ($_SESSION["userProject"] as $project) : ?>
        <a href="project?ProjetID=<?= $project->projetID ?>">
            <div class="project">
                <h2><?= $project->projetTitle ?></h2>
            </div>
        </a>
    <?php endforeach; ?>
</div>