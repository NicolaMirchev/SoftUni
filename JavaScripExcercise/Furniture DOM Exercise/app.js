window.addEventListener('load', solve);

function solve() {
    
    const modelElement = document.getElementById('model');
    const yearElement = document.getElementById('year');
    const descriptionElement = document.getElementById('description');
    const priceElement = document.getElementById('price');

    const button = document.getElementById('add');
    button.addEventListener('click', addButtonClicked);

    function addButtonClicked(event){

      

        event.preventDefault();

        const rowToAdd = document.createElement('tr');
        rowToAdd.className = 'info';

        const modelTd = document.createElement('td')
        modelTd.textContent = modelElement.value;
        const priceId = document.createElement('td');
        priceId.textContent = Number(priceElement.value).toFixed(2);

        const moreInfoButton = document.createElement('button');
        moreInfoButton.textContent = 'More Info';
        moreInfoButton.className = 'moreBtn';
        const buyItButton = document.createElement('button');
        buyItButton.textContent = 'Buy it';
        buyItButton.className = 'buyBtn';


        const hiddenInfoRow = document.createElement('tr');
        hiddenInfoRow.className = 'hide';
        const yearsbox = document.createElement('td');
        yearsbox.textContent = `Year: ${yearElement.value}`;
        const descriptionBox = document.createElement('td');
        descriptionBox.setAttribute('colspan', 3);
        descriptionBox.textContent = `Description: ${descriptionElement.textContent}`;
        hiddenInfoRow.appendChild(yearsbox);
        hiddenInfoRow.appendChild(descriptionBox);


        moreInfoButton.addEventListener('click', (e) => {
            if(e.currentTarget.textContent == 'More Info'){
                hiddenInfoRow.style.display = 'contents';
                e.currentTarget.textContent = 'Less Info';
            }
            else{
                e.currentTarget.textContent = 'More Info';
                hiddenInfoRow.style.display = 'none';
            }


        });
        buyItButton.addEventListener('click', (e) => {

            let totalSum = document.getElementsByClassName('total-price')[0];
            totalSum.textContent = ((Number(priceElement.value) + Number(totalSum.textContent)).toFixed(2));
            
            rowToAdd.remove();
            hiddenInfoRow.remove();
        })

        const buttonsDiv = document.createElement('div');
        buttonsDiv.appendChild(moreInfoButton);
        buttonsDiv.appendChild(buyItButton);

        rowToAdd.appendChild(modelTd);
        rowToAdd.appendChild(priceId);
        rowToAdd.appendChild(buttonsDiv);

        document.getElementById('furniture-list').appendChild(rowToAdd);
        document.getElementById('furniture-list').appendChild(hiddenInfoRow);
        
        document.getElementById('model').value ='';
        document.getElementById('year').value ='';
        document.getElementById('description').value ='';
        document.getElementById('price').value ='';
    }
}
