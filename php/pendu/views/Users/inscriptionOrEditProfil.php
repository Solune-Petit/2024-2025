<div class="flex space-evenly">
    <form method="post" action="">
        <fieldset>
            <legend><?php if (isset($_SESSION['user'])) : ?> Modifier vos informations <?php else : ?> Inscription  <?php endif ?></legend>
            <div class="flexible space-evenly">
                <div>
                    <div class="mb-3">
                        <label for="Nom" class="form-label">Nom</label>
                        <input type="text" placeholder="Nom" class="form-control" id="nom" name="nom" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->nomUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="Prenom" class="form-label">Prénom</label>
                        <input type="text" placeholder="Prénom" class="form-control" id="prenom" name="prenom" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->prenomUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="email" class="form-label">Email</label>
                        <input type="email" placeholder="Email" class="form-control" id="email" name="email" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->emailUser ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="Login" class="form-label">Login</label>
                        <input type="text" placeholder="Login" class="form-control" id="login" name="login" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->loginUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="Password" class="form-label">Mot de passe</label>
                        <input type="password" placeholder="Mot de passe" class="form-control" id="mot_de_passe" name="mot_de_passe" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->passWordUser ?>" <?php endif ?>>
                    </div>
                </div>
                <div>
                    <div class="mb-3">
                        <label for="adresse" class="form-label">Adressse</label>
                        <input type="adresse" placeholder="ex : 1 avenue compte de smet de Nayer" class="form-control" id="adresse" name="adresse" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->adresseUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="CPU" class="form-label">Code Postal</label>
                        <input type="int" placeholder="ex : 5000" class="form-control" id="CP" name="CP" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->CPUser ?>" <?php endif ?>>
                    </div>
                    <div class="mb-3">
                        <label for="ville" class="form-label">Ville</label>
                        <input type="ville" placeholder="ex : Namur" class="form-control" id="ville" name="ville" required <?php if (isset($_SESSION['user'])) : ?>value="<?= $_SESSION['user']->villeUser ?>" <?php endif ?>>
                    </div>
                </div>
            </div>
                <div>
                    <button name="btnEnvoi" <?php if (isset($_SESSION['user'])) : ?> class="btn btn-primary btn-big-custom"> modifier le profil<?php else : ?>class="btn btn-primary btn-big">Valider<?php endif ?></button>
                </div>
        </fieldset>

        
        <?php
        if (isset($_SESSION['user'])) : ?> 
        <a href="deleteProfile" class="btn btn-secondary" style="background-color: red;">SUPRIMER LE PROFIL</a>
        <?php else : ?> <h4 class="text-danger">Déjà inscrit ?</h4>
            <a href="connexion" class="btn btn-secondary">Cliquez ici !</a> <?php endif ?>
    </form>
</div>