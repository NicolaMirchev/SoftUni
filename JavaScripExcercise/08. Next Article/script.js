function getArticleGenerator(articles) {
    
    const array = articles;
    const ar = [];

    return function () {

        const field = document.getElementById('content');
        field.textContent = array.shift();
    }

}
