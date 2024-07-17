// loader

document.addEventListener("DOMContentLoaded", function() {
    // Sélectionnez votre élément de chargement (loader)
    var loader = document.getElementById("loader");

    // Affichez le loader lorsque la page commence à charger
    loader.style.display = "block";

    // Cachez le loader une fois que la page a été entièrement chargée
    window.addEventListener("load", function() {
        loader.style.display = "none";
    });
});

