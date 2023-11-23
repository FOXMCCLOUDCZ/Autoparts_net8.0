function setupLiveCharacterCount(inputId, charCountId, maxLength) {
    var input = document.getElementById(inputId);
    var charCountSpan = document.getElementById(charCountId);

    input.addEventListener("input", function () {
        var currentLength = input.value.length;
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