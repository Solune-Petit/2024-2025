<div class="flexible space-evenly align-item-center menu">
    <a href="game" class="menuBtn">game</a>
    <?php if(isset($_SESSION["user"]->userStatus) == "user" || isset($_SESSION["user"]->userStatus) == "admin"):?>
        <a href="Profile" class="menuBtn">Your profile</a>
        <a href="LogOf" class="menuBtn">Log Off</a>
    <?php else:?>
        <a href="/LogIn" class="menuBtn">Log In</a>
    <?php endif?>
</div>

