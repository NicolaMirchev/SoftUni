function addItem() {
    const value = document.getElementById('newItemText').value;

    const uList = document.getElementById('items');

    const el = document.createElement('li');
    el.textContent = value;

    const removeButton = document.createElement('a');
     removeButton.href = '#';
     removeButton.textContent = '[Delete]';

     removeButton.addEventListener('click', removeRow)
     el.appendChild(removeButton);

    uList.appendChild(el);


    function removeRow(ev){
       ev.target.parentNode.remove();
    }

    
    document.getElementById('newItemText').value = '';

}