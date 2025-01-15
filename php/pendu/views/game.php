<!-- Main app display -->
<div style="margin: 0 auto; background: #dddddd; width:900px; height:900px; padding:5px; border-radius:3px;">

    <!-- Display the image here -->
    <div style="display:inline-block; width: 500px; background:#fff;">
        <img style="width:80%; display:inline-block;" src="<?php echo getCurrentPicture(getCurrentPart()); ?>" />

        <!-- Indicate game status -->
        <?php if (gameComplete()): ?>
            <h1>GAME COMPLETE</h1>
        <?php endif; ?>
        <?php if ($WON == true  && gameComplete()): ?>
            <p style="color: darkgreen; font-size: 25px;">You Won! HURRAY! :)</p>
        <?php elseif ($WON == false  && gameComplete()): ?>
            <p style="color: darkred; font-size: 25px;">You LOST! OH NO! :(</p>
            <p>the word was <?= $_SESSION["word"] ?></p>
            <?=var_dump($WON);?>

        <?php endif; ?>
    </div>

    <div style="float:right; display:inline; vertical-align:top;">
        <h1>Hangman the Game</h1>
        <div style="display:inline-block;">
            <form method="get">
                <?php
                $max = strlen($letters) - 1;
                for ($i = 0; $i <= $max; $i++) {
                    echo "<button type='submit' name='kp' value='" . $letters[$i] . "'>" .
                        $letters[$i] . "</button>";
                    if ($i % 7 == 0 && $i > 0) {
                        echo '<br>';
                    }
                }
                ?>
                <br><br>
                <!-- Restart game button -->
                <button type="submit" name="start">Restart Game</button>
            </form>
        </div>
    </div>

    <div style="margin-top:20px; padding:15px; background: lightseagreen; color: #fcf8e3">
        <!-- Display the current guesses -->
        <?php
        $guess = getCurrentWord();
        $maxLetters = strlen($guess) - 1;
        for ($j = 0; $j <= $maxLetters; $j++): $l = getCurrentWord()[$j]; ?>
            <?php if (in_array($l, getCurrentResponses())): ?>
                <span style="font-size: 35px; border-bottom: 3px solid #000; margin-right: 5px;"><?php echo $l; ?></span>
            <?php else: ?>
                <span style="font-size: 35px; border-bottom: 3px solid #000; margin-right: 5px;">&nbsp;&nbsp;&nbsp;</span>
            <?php endif; ?>
        <?php endfor; ?>
    </div>

</div>






</html>