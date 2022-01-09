function generateReport() {
    //check the checks and put them in array
    const firstRow = document.querySelector('tr').cells;

    const rows = document.querySelectorAll('tr');

    //create array for the objects 
    const objectArray = [];
    
    // make an object and put in it the array of obects
    for(let i = 1; i < rows.length; i++){
        const currentObject = {};
        
        for(let j = 0; j < firstRow.length; j++ ){

            if(firstRow[j].lastElementChild.checked){

                let cells = rows[i].children;
                let names = cells[j].textContent;

                currentObject[firstRow[j].textContent] = names; 
            }

        }

        objectArray.push(currentObject);
    }

document.getElementById('output').textContent =JSON.stringify(objectArray);

    // print object - stingified

    //
}