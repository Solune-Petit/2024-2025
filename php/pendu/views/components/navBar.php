<div class="flexible space-evenly header">
    <button class="menu"><a href="game">game</a></button>
    <?php if(isset($_SESSION["user"])):?>
        <button class="menu"><a href="Profile">Your profile</a></button>
        <button class="menu"><a href="LogOf">Log Off</a></button>
    <?php else:?>
        <button class="menu"><a href="/LogIn">Log In</a></button>
    <?php endif?>
</div>