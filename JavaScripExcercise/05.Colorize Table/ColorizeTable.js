function colorize() {

    const rows = document.querySelectorAll('tr');

    for( let i = 1; i  < rows.length; i += 2){

        rows[i].lastChild.bgColor = 'Teal';

    }


}