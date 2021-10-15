let button = document.getElementById('button');

button.addEventListener('click', (e) => {
    var textHTML = document.getElementById('textHTML').value;

    const byteSize = str => await new Blob([str]).size;
    var sizeInMB = await byteSize(textHTML) / (1024 * 1024)

    //maximum size of textbox is 4.76837158203125MB
    //TODO: resize

    var result;
    if (sizeInMB < 5) {
        result = textHTML;
    } else {
        result = "Too large file, size of 5MB can not be exceeded!";
    }

    document.getElementById('text').innerHTML = result;
})