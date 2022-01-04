function extractText() {
    const elements = document.getElementById('items').children;

    const result = [];

    for (element of elements){

        result.push(element.textContent);
    }

    document.getElementById('result').textContent = result.join('\n');
}