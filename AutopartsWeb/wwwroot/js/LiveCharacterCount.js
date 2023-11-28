function setupLiveCharacterCount(inputId, charCountId, maxLength) {
    var input = document.getElementById(inputId);
    var charCountSpan = document.getElementById(charCountId);

    // Aktualizujeme počet znaků při načtení stránky
    var currentLength = input.value.length;
    charCountSpan.textContent = currentLength + "/" + maxLength;

    input.addEventListener("input", function () {
        currentLength = input.value.length;
        var remainingChars = maxLength - currentLength;

        charCountSpan.textContent = currentLength + "/" + maxLength;

        // Přidání barvy textu při překročení limitu znaků
        if (currentLength > maxLength) {
            charCountSpan.style.color = "red";
        } else {
            charCountSpan.style.color = "";
        }
    });
}