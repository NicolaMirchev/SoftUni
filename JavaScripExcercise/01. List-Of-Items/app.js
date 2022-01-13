function addItem() {
    const value = document.getElementById('newItemText').value;

    const uList = document.getElementById('items');

    const el = document.createElement('li');
    uList.appendChild(el).textContent = value;
    
    document.getElementById('newItemText').value = '';

    
}