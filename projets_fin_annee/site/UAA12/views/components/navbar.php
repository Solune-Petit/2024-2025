<ul class="flexible space-around header align-item-center">

    <li class="menu"><a href="home"><span class="material-symbols-outlined menu-home">home</span></a></li>
    
    <!-- ajouter des trucs avant ici -->
    <?php if (isset($_SESSION["user"]) && $url != "/profile") : ?>
        <li class="menu"><a href="profile"><span class="material-symbols-outlined menu-profile">account_circle</span></a></li>
    <?php elseif ($url != "/profile") : ?>
    <li class="menu"><a href="identify"><span class="material-symbols-outlined menu-signIN">login</span></a></li>
    <?php endif; if ($url == "/profile") : ?>
        <li class="menu"><a href="disconnect"><span class="material-symbols-outlined">logout</span></a></li>
    <?php endif ?>

</ul>