<div class="center-wrapper">
    <div class="form-container">
        <div>
        <h2 id="formTitle">Login</h2>
        <?php if (isset($error)): ?>
            <p class="error"><?php echo $error; ?></p>
        <?php endif; ?>

        <!-- Login Form -->
        <form id="loginForm" action="" method="post">
            <div class="input-group">
                <label for="loginUsername">Username</label>
                <input type="text" id="loginUsername" name="loginUsername" required>
            </div>
            <div class="input-group">
                <label for="loginPassword">Password</label>
                <input type="password" id="loginPassword" name="loginPassword" required>
            </div>
            <button type="submit" name="loginBtn" class="btn">Login</button>
        </form>

        <!-- Registration Form (initially hidden) -->
        <form id="registerForm" action="" method="post" style="display: none;">
            <div class="input-group">
                <label for="registerName">name</label>
                <input type="text" id="registerName" name="registerName" required>
            </div>
            <div class="input-group">
                <label for="registerSurname">Surname</label>
                <input type="text" id="registerSurname" name="registerSurname" required>
            </div>
            <div class="input-group">
                <label for="registerEmail">Email</label>
                <input type="email" id="registerEmail" name="registerEmail" required>
            </div>
            <div class="input-group">
                <label for="registerLogin">login</label>
                <input type="text" id="registerLogin" name="registerLogin" required>
            </div>
            <div class="input-group">
                <label for="registerPassword">Password</label>
                <input type="password" id="registerPassword" name="registerPassword" required>
            </div>
            <button type="submit" name="registerBtn" class="btn">Register</button>
        </form>
        </div>

        <p id="switchText">
            Pas encore inscrit ? <br> <a href="#" id="switchForm">Inscrivez-vous ici</a>
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