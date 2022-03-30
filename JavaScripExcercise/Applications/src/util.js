import { del, get, logout, post, put } from "./api/api.js";

export function setUserData(data){
    sessionStorage.setItem('userData', JSON.stringify(data));

    
}
export function getUserData(){
   return JSON.parse(sessionStorage.getItem('userData'));
}
export function clearUserData(){
    sessionStorage.removeItem('userData');
}

export function updateNav(){
    if (sessionStorage['userData']){
        document.querySelector('.guest').style.display = 'none';
        document.querySelector('.user').style.display = 'block';

        const logoutBtn = document.getElementById('logoutBtn');
        logoutBtn.addEventListener('click', function() {
            clearUserData();
            updateNav();
        } )

        logoutBtn.style.display = 'block';
        document.querySelector('.profile span').textContent = `Welcome, ${getUserData().email}`;

    }
    else {
        document.querySelector('.guest').style.display = 'block';
       document.querySelector('.user').style.display = 'none';

        document.getElementById('logoutBtn').style.display = 'none';
    }
}

export async function getMemeById(id){
    return await get('/data/memes/' + id);
}

export async function createMeme(data){
    post('/data/memes' , data);

}

export async function deleteMemeById(id){
    return await del('/data/memes/' + id);
}

export async function editMemeById(id, data){

    return await put('/data/memes/' + id, data);
}
