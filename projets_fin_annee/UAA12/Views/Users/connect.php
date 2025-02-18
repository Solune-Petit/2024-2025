<?php
var_dump($_SESSION["user"]);
?>

<div class="center-wrapper">
    <div class="form-container">
        <h2 id="formTitle">Login</h2>
        <?php if (isset($error)): ?>
            <p class="error"><?php echo $error; ?></p>
        <?php endif; ?>

        <!-- Login Form -->
        <form id="loginForm" action="connexion" method="post">
            <div class="input-group">
                <label for="loginUsername">Username</label>
                <input type="text" id="loginUsername" name="login" required>
            </div>
            <div class="input-group">
                <label for="loginPassword">Password</label>
                <input type="password" id="loginPassword" name="mot_de_passe" required>
            </div>
            <button type="submit" name="loginBtn" class="btn">Login</button>
        </form>

        <!-- Registration Form (initially hidden) -->
        <form id="registerForm" action="inscriptionOrEditProfil" method="post" style="display: none;">
            <div class="input-group">
                <label for="registerUsername">Username</label>
                <input type="text" id="registerUsername" name="login" required>
            </div>
            <div class="input-group">
                <label for="registerPassword">Password</label>
                <input type="password" id="registerPassword" name="mot_de_passe" required>
            </div>
            <div class="input-group">
                <label for="registerEmail">Email</label>
                <input type="email" id="registerEmail" name="email" required>
            </div>
            <button type="submit" name="registerBtn" class="btn">Register</button>
        </form>

        <p id="switchText">
            Pas encore inscrit ? <a href="#" id="switchForm">Inscrivez-vous ici</a>
        </p>
    </div>
</div>

<script>
    document.addEventListener('DOMContentLoaded', function() {
    const loginForm = document.getElementById('loginForm');
    const registerForm = document.getElementById('registerForm');
    const formTitle = document.getElementById('formTitle');
    const switchText = document.getElementById('switchText');

    // Use event delegation
    document.body.addEventListener('click', function(e) {
        if (e.target && e.target.id === 'switchForm') {
            e.preventDefault();
            if (loginForm.style.display !== 'none') {
                loginForm.style.display = 'none';
                registerForm.style.display = 'block';
                formTitle.textContent = 'Register';
                switchText.innerHTML = 'Déjà inscrit ? <a href="#" id="switchForm">Connectez-vous ici</a>';
            } else {
                loginForm.style.display = 'block';
                registerForm.style.display = 'none';
                formTitle.textContent = 'Login';
                switchText.innerHTML = 'Pas encore inscrit ? <a href="#" id="switchForm">Inscrivez-vous ici</a>';
            }
        }
    });
});
</script>