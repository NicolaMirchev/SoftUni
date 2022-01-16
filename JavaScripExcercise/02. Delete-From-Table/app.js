function deleteByEmail() {
    const input = document.querySelector('input');

    const rows = document.querySelectorAll('tbody tr');

    for (row of rows){
        if(row.lastElementChild.textContent == input.value){
            row.remove(row);
        }
    }

    input.value = '';
}