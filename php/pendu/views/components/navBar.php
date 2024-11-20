<div class="flexible space-evenly header">
    <button class="menu">Menu</button>
    <?php if(isset($_SESSION["user"])):?>
        <button class="menu">Your profile</button>
        <button class="menu">Log Off</button>
    <?php else:?>
        <button class="menu">Log In</button>
        <button class="menu">Sign In</button>
    <?php endif?>
</div>