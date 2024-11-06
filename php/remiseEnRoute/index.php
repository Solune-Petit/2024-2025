<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="index.css">
</head>
<body>
    
    <header>        
    </header>
    <main>
        <form action="">
            <fieldset>
                <legend>Please enter your billing information</legend>
                <div class="input">
                    <label for="cardType">Card Type</label>
                    <select name="cardType" id="cardType" required>
                        <option value="Default" placeholder> Select card type</option>
                        <option value="MasterCard">MasterCard</option>
                        <option value="Maestro">Maestro</option>
                        <option value="Cirrus">Cirrus</option>
                        <option value="switch">switch</option>
                        <option value="Solo">Solo</option>
                        <option value="G">G</option>
                        <option value="Discover">Discover</option>
                        <option value="Visa">Visa</option>
                        <option value="VisaElectron">Visa Electron</option>
                        <option value="DirectDebit">Direct Debit</option>
                        <option value="PayPal">PayPal</option>
                        <option value="AmericanExpress">American Express</option>
                    </select>
                </div>
                <div class="input">
                    <label for="CardNumber">Card Number</label>
                    <input type="text" required>
                </div>
                <div class="input">
                    <label for="Expire">Expires on</label>
                    <select name="expCardMonth" id="exCardMonth" required>
                        <option value="Default"  placeholder>Month</option>
                        <option value="january">january</option>
                        <option value="february">february</option>
                        <option value="march">march</option>
                        <option value="april">april</option>
                        <option value="mai">mai</option>
                        <option value="june">june</option>
                        <option value="july">july</option>
                        <option value="august">august</option>
                        <option value="september">september</option>
                        <option value="october">october</option>
                        <option value="november">november</option>
                        <option value="december">december</option>
                    </select>
                    <select name="expCardYear" id="expCardYear" required>
                        <option value="Default" placeholder>Year</option>
                        <option value="2024">2024</option>
                        <option value="2025">2025</option>
                        <option value="2026">2026</option>
                        <option value="2027">2027</option>
                        <option value="2028">2028</option>
                        <option value="2029">2029</option>
                        <option value="2030">2030</option>
                        <option value="2031">2031</option>
                        <option value="2032">2032</option>
                        <option value="2033">2033</option>
                        <option value="2034">2034</option>
                        <option value="2035">2035</option>
                        <option value="2036">2036</option>
                        <option value="2037">2037</option>
                        <option value="2038">2038</option>
                        <option value="2039">2039</option>
                        <option value="2040">2040</option>
                    </select>
                </div>
                <div class="input">
                    <label for="CVV">CVV</label>
                    <input type="text" required>
                </div>
                <button type="submit">Checkout</button>
            </fieldset>
        </form>
    </main>
    <footer>
    </footer>

</body>
</html>