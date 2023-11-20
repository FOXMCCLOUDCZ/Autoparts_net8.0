function setupLiveCharacterCount(inputId, charCountId, maxLength) {
    var input = document.getElementById(inputId);
    var charCountSpan = document.getElementById(charCountId);

    input.addEventListener("input", function () {
        var currentLength = input.value.length;
        var remainingChars = maxLength - currentLength;
        charCountSpan.textContent = remainingChars;
    });
}